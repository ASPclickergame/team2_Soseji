using growing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Growing
{
    public partial class Form1 : Form
    {
        private DatabaseManager DB;
        private MDLstock md;
        public int money = 0;
        private List<Button> hireButtons;
        public List<Stock> Lstock;
        private Dictionary<Timer, Worker> timerToWorker;
        private Dictionary<Timer, Label> timerToLabel;
        private Dictionary<Timer, int> timerRemainingTime;

        public int level = 1;                  //레벨    
        private int experience = 0;             //현재 경험치
        private int experiencenextlevel = 100;  //레벨업 필요 경험치
        private int clickIncome = 100;        //클릭당 수익

        private int expperclick = 20;           // 경험치 상승량 퍼센트
        private int expbuttoncost = 500;        // 경험치 버튼 비용

        private ToolTip jobToolTip = new ToolTip();     //툴팁


        public Form1()
        {
            InitializeComponent();

            SetUpDatabaseManager();
            this.DoubleBuffered = true;     //마우스 클릭 입력 속도 가속
            UpdateMoneyLabel();
            UpdateLevelLabel();
        }

        // Worker 리스트
        private List<Worker> workers = new List<Worker>
        {
            new Worker("노숙자", 3000, 100, 3000, 5),
            new Worker("전단지 알바", 10000, 500, 10000, 10),
            new Worker("편의점 알바", 300000, 3000, 30000, 15),
            new Worker("공무원", 600000, 10000, 60000, 20),
            new Worker("건물주", 1800000, 50000, 180000, 30)
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            // 버튼 순서 일치
            hireButtons = new List<Button> { firstJobBTN, secondJobBTN, thirdJobBTN, forthJobBTN, fifthJobBTN };

            // 버튼 상태 0.1초마다 체크
            btncheckTMR.Interval = 100;
            btncheckTMR.Tick += (s, eArgs) => UpdateButtonStates();
            btncheckTMR.Start();


            //gameTMR.Interval = 100;
            //gameTMR.Tick += (s, eArgs) =>
            //{
            //    money += 1;
            //    UpdateMoneyLabel();
            //};
            //gameTMR.Start();

            // 각 알바 타이머 -> 알바 매핑
            timerToWorker = new Dictionary<Timer, Worker>
            {
                { firstJobTMR, workers[0] },
                { secondJobTMR, workers[1] },
                { thirdJobTMR, workers[2] },
                { forthJobTMR, workers[3] },
                { fifthJobTMR, workers[4] }
            };

            // 타이머마다 Tick 이벤트 설정
            foreach (var pair in timerToWorker)
            {
                pair.Key.Interval = pair.Value.Interval;
                Worker w = pair.Value;
            }

            // 타이머 -> 남은 시간 표시할 라벨
            timerToLabel = new Dictionary<Timer, Label>
            {
                { firstJobTMR, firstJobTimerLBL },
                { secondJobTMR, secondJobTimerLBL },
                { thirdJobTMR, thirdJobTimerLBL },
                { forthJobTMR, forthJobTimerLBL },
                { fifthJobTMR, fifthJobTimerLBL }
            };

            // 타이머 -> 남은 시간 (ms)
            timerRemainingTime = new Dictionary<Timer, int>();
            foreach (var pair in timerToWorker)
            {
                timerRemainingTime[pair.Key] = pair.Value.Interval;
            }

            updateCountdownTMR.Interval = 100; // 0.1초 간격으로 정밀하게 표시
            updateCountdownTMR.Tick += UpdateRemainingTimes;
            updateCountdownTMR.Start();

            jobToolTip.InitialDelay = 0; // 마우스를 올리면 툴팁 바로 표시
            jobToolTip.ReshowDelay = 0; // 지연 없이 툴팁 표시 
            jobToolTip.ShowAlways = true; // 컨트롤이 false여도 표시

            for (int i = 0; i < workers.Count; i++)
            {
                Worker w = workers[i];
                Button btn = hireButtons[i];

                string tooltipText = $"Lv {w.RequiredLevel} 필요 - 클릭하여 고용"; //버튼 위에 마우스 올라가면 툴팁 표시
                jobToolTip.SetToolTip(btn, tooltipText);
            }

            UpdateButtonStates();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            PlayerData playerData = new PlayerData("정보보안의 갓핸드_박요한", money, level, experience, experiencenextlevel, clickIncome, expperclick);
            playerData.SetWorkers(workers);
            DB.SavePlayerData(playerData);
        }

        private void SetUpDatabaseManager()
        {
            // database set up function

            DB = DatabaseManager.GetInstance();

            if (File.Exists(DB.savePath + "save.csv"))
            {
                // 초기화가 됐다면
                DB.LoadingPlayerData();
                money = DB.GetMoney();
                level = DB.GetLevel();
                experience = DB.GetExp();
                experiencenextlevel = DB.GetExpNextLevel();
                clickIncome = DB.GetClickIncome();
                expperclick = DB.GetExpPerClick();
            }
            else
            {
                // 엄
            }
        }

        private void HireWorker(Worker worker, Timer tmr)
        {
            //고용에 필요한 레벨
            if (level < worker.RequiredLevel)
            {
                MessageBox.Show($"이 직업은 레벨 {worker.RequiredLevel} 이상부터 고용할 수 있습니다.");
                return;
            }

            if (money >= worker.Cost && !worker.IsHired)
            {
                money -= worker.Cost;
                worker.IsHired = true;
                tmr.Start();
                UpdateMoneyLabel();
            }
        }

        public void UpdateMoneyLabel()
        {
            moneyLBL.Text = $"{money}원";
        }

        private void UpdateButtonStates()
        {
            for (int i = 0; i < workers.Count; i++)
            {
                Worker w = workers[i];
                Button btn = hireButtons[i];

                //고용 추가 제한(레벨 제한도 추가)
                if (level < w.RequiredLevel)
                {
                    btn.Enabled = true;
                    btn.Text = $"{w.Name} (Lv {w.RequiredLevel}) : 잠김";
                    btn.BackColor = Color.Gray;

                    btn.Tag = "Locked"; //클릭 안됨
                }
                else if (w.IsHired)
                {
                    btn.Enabled = false;
                    btn.Text = $"{w.Name}: {w.Interval / 1000}초당 {w.Income:N0}원";
                    btn.BackColor = Color.LightGreen;
                }
                else if (money >= w.Cost)
                {
                    btn.Enabled = true;
                    btn.Text = $"{w.Name} : {w.Cost:N0}원";
                    btn.BackColor = SystemColors.Control;
                }
                else
                {
                    btn.Enabled = false;
                    btn.Text = $"{w.Name} : {w.Cost:N0}원";
                    btn.BackColor = Color.LightCoral;
                }
            }
        }

        private void UpdateRemainingTimes(object sender, EventArgs e)
        {
            foreach (var pair in timerToWorker)
            {
                Timer tmr = pair.Key;
                Worker worker = pair.Value;

                if (!worker.IsHired)
                {
                    timerToLabel[tmr].Text = "";
                    continue;
                }

                timerRemainingTime[tmr] -= updateCountdownTMR.Interval;

                if (timerRemainingTime[tmr] <= 0)
                {
                    // 수익 지급
                    money += worker.Income;
                    UpdateMoneyLabel();

                    // 타이머 초기화
                    timerRemainingTime[tmr] = worker.Interval;
                }

                double secondsLeft = timerRemainingTime[tmr] / 1000.0;
                timerToLabel[tmr].Text = $"남은 시간: {secondsLeft:0.0}초";
            }
        }



        private void firstJobBTN_Click(object sender, EventArgs e)
        {
            HireWorker(workers[0], firstJobTMR);
        }

        private void secondJobBTN_Click(object sender, EventArgs e)
        {
            HireWorker(workers[1], secondJobTMR);
        }

        private void thirdJobBTN_Click(object sender, EventArgs e)
        {
            HireWorker(workers[2], thirdJobTMR);
        }

        private void forthJobBTN_Click(object sender, EventArgs e)
        {
            HireWorker(workers[3], forthJobTMR);
        }

        private void fifthJobBTN_Click(object sender, EventArgs e)
        {
            HireWorker(workers[4], fifthJobTMR);
        }

        private void clickPNL_Click(object sender, EventArgs e)
        {
            money += clickIncome;
            UpdateMoneyLabel();
        }

        //레벨 업데이트
        private void UpdateLevelLabel()
        {
            levelLBL.Text = $"레벨: {level}";

            double percent = (double)experience / experiencenextlevel * 100;
            expLBL.Text = $"경험치: {percent:0.0}%";



            // 레벨업 버튼 텍스트 업데이트
            levelupBTN.Text = $"레벨 업(F)\n{expbuttoncost:N0}원";
        }


        //경험치 획득
        private void gainexperience(int amount)
        {
            experience += amount;

            //경험치 만족
            if (experience >= experiencenextlevel)
            {
                experience -= experiencenextlevel;
                level++;
                clickIncome = (int)(clickIncome * 1.5);


                // 레벨업 필요 경험치 증가
                experiencenextlevel = (int)(experiencenextlevel * 1.4);

                // 레벨업 버튼 가격 증가
                expbuttoncost = (int)(expbuttoncost * 1.4);

                MessageBox.Show($"레벨 업! 현재 레벨: {level}\n클릭당 수익: {clickIncome}원");
            }

            UpdateLevelLabel();
        }

        //레벨업 버튼
        private void levelupBTN_Click(object sender, EventArgs e)
        {
            if (money >= expbuttoncost)
            {
                money -= expbuttoncost;
                gainexperience(expperclick);
                UpdateMoneyLabel();
            }
            else
            {
                MessageBox.Show("돈이 부족합니다!");
            }
        }

        private void jusikBtn_Click(object sender, EventArgs e)
        {

            if (md == null || md.IsDisposed)
            {
                md = new MDLstock(this);
                md.Owner = this;
                md.Show();          // 모달리스로 한 번만 띄움
            }
            else
            {
                md.BringToFront(); // 이미 열려 있으면 앞으로 가져오기
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
            {
                levelupBTN.PerformClick();
            }
        }
    }
}