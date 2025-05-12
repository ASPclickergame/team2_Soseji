using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace growing
{
    internal class Stock
    {
        public string Name;
        public int Price;
        public int HaveStock;

        // 생성자
        public Stock(string name, int price)
        {
            Name = name;
            Price = price;
            HaveStock = 0;
        }

        // 구매
        public void BuyStock(int quantity, ref int Pmoney)
        {
            int totalprice = Price * quantity;
            if (totalprice > Pmoney)
            {
                MessageBox.Show("구매할 수 없습니다.");
            }
            else
            {
                Pmoney -= totalprice;
                HaveStock += quantity;
                MessageBox.Show($"{Name} 주식 {quantity}개를 구매했습니다!");
            }
        }

        // 판매
        public void SellStock(int quantity, ref int Pmoney)
        {
            if (HaveStock < quantity)
            {
                MessageBox.Show("보유 수량이 부족합니다.");
            }
            else
            {
                int totalprice = Price * quantity;
                HaveStock -= quantity;
                Pmoney += totalprice;
                MessageBox.Show($"{Name} 주식 {quantity}개를 판매했습니다!");
            }
        }
    }
}

