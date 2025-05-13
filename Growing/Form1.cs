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
        private int money = 0;
        private List<Button> hireButtons;
        private Dictionary<Timer, Worker> timerToWorker;
        private Dictionary<Timer, Label> timerToLabel;
        private Dictionary<Timer, int> timerRemainingTime;

        public Form1()
        {
            InitializeComponent();
            SetUpDatabaseManager();
        }

        private void SetUpDatabaseManager()
        {
            // database set up function

            DB = DatabaseManager.GetInstance();

            if (File.Exists(DB.savePath + "save.csv")) {
                // 초기화가 됐다면
                DB.LoadingPlayerData();
                money = DB.GetMoney();
            }
            else
            {
                // 엄
            }
        }

        // Worker 리스트
        private List<Worker> workers = new List<Worker>
        {
            new Worker("노숙자", 3000, 100, 3000),
            new Worker("전단지 알바", 10000, 500, 10000),
            new Worker("편의점 알바", 300000, 3000, 30000),
            new Worker("공무원", 600000, 10000, 60000),
            new Worker("건물주", 1800000, 50000, 180000)
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;

            // 버튼 순서 일치
            hireButtons = new List<Button> { firstJobBTN, secondJobBTN, thirdJobBTN, forthJobBTN, fifthJobBTN };

            // 버튼 상태 0.1초마다 체크
            btncheckTMR.Interval = 100;
            btncheckTMR.Tick += (s, eArgs) => UpdateButtonStates();
            btncheckTMR.Start();

            // 1초마다 10원 자동 수익
            gameTMR.Interval = 100;
            gameTMR.Tick += (s, eArgs) =>
            {
                money += 1;
                UpdateMoneyLabel();
            };
            gameTMR.Start();

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

            UpdateButtonStates();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DB.SavePlayerData(new PlayerData("정보보안의 갓핸드_박요한", money));
        }

        private void HireWorker(Worker worker, Timer tmr)
        {
            if (money >= worker.Cost && !worker.IsHired)
            {
                money -= worker.Cost;
                worker.IsHired = true;
                tmr.Start();
                UpdateMoneyLabel();
            }
        }

        private void UpdateMoneyLabel()
        {
            moneyLBL.Text = $"{money}원";
        }

        private void UpdateButtonStates()
        {
            for (int i = 0; i < workers.Count; i++)
            {
                Worker w = workers[i];
                Button btn = hireButtons[i];

                if (w.IsHired)
                {
                    btn.Enabled = false;
                    btn.Text = $"{w.Name}: {w.Interval / 1000}초당 {w.Income:N0}원";
                    btn.BackColor = Color.LightGreen;
                }
                else if (money >= w.Cost)
                {
                    btn.Enabled = true;
                    btn.Text = $"{w.Name} : {w.Cost:N0}원";
                    btn.BackColor = SystemColors.Control; // 기본 색으로 복원
                }
                else
                {
                    btn.Enabled = false;
                    btn.Text = $"{w.Name} : {w.Cost:N0}원";
                    btn.BackColor = Color.LightCoral; // 빨간색 느낌의 비활성 색
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
            money += 100;
            UpdateMoneyLabel();
        }

    }

    public class Worker
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Income { get; set; }
        public int Interval { get; set; } // ms
        public bool IsHired { get; set; } = false;

        public Worker(string name, int cost, int income, int interval)
        {
            Name = name;
            Cost = cost;
            Income = income;
            Interval = interval;
        }
    }
}