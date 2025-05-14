using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace growing
{
    internal class Stock
    {
        public string Name;
        public int Price;
        public int HaveStock;
        private static Random rand = new Random();
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

        // 이벤트 적용 (외부에 알릴 필요 없음)
        public void ApplyEvent(string description, double percentChange)
        {
            int delta = (int)(Price * (percentChange / 100.0));
            int newPrice = Price + delta;
            if (newPrice < 1) newPrice = 1;

            Price = newPrice;

            MessageBox.Show($"{Name} 주식에 이벤트 발생: {description}\n" +
                            $"가격이 {percentChange:+0.##;-0.##}% 변동되어 현재 가격: {Price}원");
        }

        // 호재 / 악재 랜덤 이벤트 생성
        public void TriggerRandomEvent()
        {
            string[] goodNews = new string[]
            {
                "신제품 출시 대성공",
                "글로벌 시장 진출 확정",
                "분기 실적 최고치 갱신",
                "자동차 AI 기술 상용화 성공",
                "정부 보조금 수혜"
            };

            string[] badNews = new string[]
            {
                "CEO 스캔들 발생",
                "안전성 문제로 리콜",
                "해외 규제 강화",
                "공장 화재 발생",
                "기술 유출 의혹",
                "대통령의 계엄령 선포"
            };

            bool isGood = rand.Next(2) == 0;
            string description;
            double percentChange;

            if (isGood)
            {
                description = goodNews[rand.Next(goodNews.Length)];
                percentChange = rand.Next(3, 16); // +3%~+15%
            }
            else
            {
                description = badNews[rand.Next(badNews.Length)];
                percentChange = -rand.Next(3, 16); // -3%~-15%
            }

            ApplyEvent(description, percentChange);

        }
    }
}

