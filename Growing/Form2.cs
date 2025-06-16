using growing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Growing
{
    public partial class MDLstock : Form
    {
        public List<Stock> stocks = new List<Stock>();
        public Form1 mainForm;
        public Label labelMoney;
        public List<Label> labelsPrice = new List<Label>();
        public List<Label> labelsHave = new List<Label>();
        public List<Button> buttons = new List<Button>();
        public int selectedIdx = 0;

        public List<List<int>> priceHistories = new List<List<int>>();
        public const int maxHistory = 50; // 차트에 보여줄 최대 구간
        public string[] stockNames = { "광운전자", "광운중공업", "광운자동차", "광운소프트" };
        public Color[] stockColors = { Color.Blue, Color.Red, Color.Green, Color.Orange };

        public MDLstock(Form1 main)
        {
            InitializeComponent();
            mainForm = main;
            timer1.Start();
        }

        private void MDlstock_Load(object sender, EventArgs e)
        {
            stocks.Add(new Stock("광운전자", 1000,this));
            stocks.Add(new Stock("광운중공업", 500,this));
            stocks.Add(new Stock("광운자동차", 5000, this));
            stocks.Add(new Stock("광운소프트", 2000, this));

            priceHistories.Clear();
            for (int i = 0; i < stocks.Count; i++)
                priceHistories.Add(new List<int>());
            UpdateChart();

            initializeLabels();
            UpdateLabels();

            
        }

        public void initializeLabels()
        {
            labelsPrice.Add(curPrice1);
            labelsPrice.Add(curPrice2);
            labelsPrice.Add(curPrice3);
            labelsPrice.Add(curPrice4);

            labelsHave.Add(stockNum1);
            labelsHave.Add(stockNum2);
            labelsHave.Add(stockNum3);
            labelsHave.Add(stockNum4);

            buttons.Add(kwangE);
            buttons.Add(kwangJ);
            buttons.Add(kwangC);
            buttons.Add(kwangS);
        }
        public void UpdateLabels()
        {
            for (int i = 0; i < stocks.Count; i++)
            {
                labelsPrice[i].Text = stocks[i].Price.ToString();
                labelsHave[i].Text = stocks[i].HaveStock.ToString();
            }
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            int count = 1;
            if (txt_개수.Text != "")
            {
                count = Convert.ToInt32(txt_개수.Text);
            }
            else
            {
                count = 1;
            }
            stocks[selectedIdx].BuyStock(count, ref mainForm.money);
            UpdateLabels();
            mainForm.UpdateMoneyLabel(); // 메인폼 라벨도 즉시 갱신
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            int count = 1;
            if (txt_개수.Text != "")
            {
                count = Convert.ToInt32(txt_개수.Text);
            }
            else
            {
                count = 1;
            }
            stocks[selectedIdx].SellStock(count, ref mainForm.money);
            UpdateLabels();
            mainForm.UpdateMoneyLabel();
        }

        private void btnSelect0_Click(object sender, EventArgs e) { selectedIdx = 0; UpdateSelectUI(); }
        private void btnSelect1_Click(object sender, EventArgs e) { selectedIdx = 1; UpdateSelectUI(); }
        private void btnSelect2_Click(object sender, EventArgs e) { selectedIdx = 2; UpdateSelectUI(); }
        private void btnSelect3_Click(object sender, EventArgs e) { selectedIdx = 3; UpdateSelectUI(); }

        private void UpdateSelectUI()
        {
            // 모든 버튼을 기본색으로
            kwangE.BackColor = SystemColors.Control;
            kwangJ.BackColor = SystemColors.Control;
            kwangC.BackColor = SystemColors.Control;
            kwangS.BackColor = SystemColors.Control;

            // 선택된 것만 강조색으로
            if (selectedIdx == 0) kwangE.BackColor = Color.LightBlue;
            else if (selectedIdx == 1) kwangJ.BackColor = Color.LightBlue;
            else if (selectedIdx == 2) kwangC.BackColor = Color.LightBlue;
            else if (selectedIdx == 3) kwangS.BackColor = Color.LightBlue;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int idx = rnd.Next(stocks.Count);

            // 해당 종목에 이벤트 발생 (예: 가격 변동)
            stocks[idx].TriggerRandomEvent();


            for (int i = 0; i < stocks.Count; i++)
            {
                priceHistories[i].Add(stocks[i].Price);
                if (priceHistories[i].Count > maxHistory)
                    priceHistories[i].RemoveAt(0);
            }
            UpdateChart();

            // UI 갱신
            UpdateLabels();

            // 필요시 메인폼 자금도 갱신
            mainForm.UpdateMoneyLabel();
        }
        public void UpdateChart()
        {
            chartPrice.Series.Clear();

            int seriesCount = Math.Min(stocks.Count, priceHistories.Count);

            int yMin = int.MaxValue, yMax = int.MinValue;

            for (int i = 0; i < seriesCount; i++)
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series(stockNames[i]);
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series.Color = stockColors[i];
                series.BorderWidth = 2;

                for (int j = 0; j < priceHistories[i].Count; j++)
                {
                    int price = priceHistories[i][j];
                    series.Points.AddXY(j, price);
                    if (price < yMin) yMin = price;
                    if (price > yMax) yMax = price;
                }
                chartPrice.Series.Add(series);
            }

            // 축 자동 스케일링
            if (yMin != int.MaxValue && yMax != int.MinValue)
            {
                chartPrice.ChartAreas[0].AxisY.Minimum = Math.Max(0, yMin - 100);
                chartPrice.ChartAreas[0].AxisY.Maximum = yMax + 100;
            }
        }

        public void ShowNews(string news)
        {
            newsBox.AppendText(news + Environment.NewLine);
            newsBox.ScrollToCaret();
        }
        private void txt_개수_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void stockNum4_Click(object sender, EventArgs e)
        {

        }

        private void stockNum3_Click(object sender, EventArgs e)
        {

        }
    }
}
