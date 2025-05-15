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
        public MDLstock(Form1 main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void MDlstock_Load(object sender, EventArgs e)
        {
            stocks.Add(new Stock("광운전자", 100000));
            stocks.Add(new Stock("광운중공업", 85000));
            stocks.Add(new Stock("광운자동차", 75000));
            stocks.Add(new Stock("광운소프트", 95000));
            
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
            int idx = (int)((Button)sender).Tag;
            stocks[idx].BuyStock(1, ref mainForm.money); // Form1의 money 사용!
            UpdateLabels();
            mainForm.UpdateMoneyLabel(); // 메인폼 라벨도 즉시 갱신
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            int idx = (int)((Button)sender).Tag;
            stocks[idx].SellStock(1, ref mainForm.money);
            UpdateLabels();
            mainForm.UpdateMoneyLabel();
        }
    }
}
