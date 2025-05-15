using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace growing
{
    public struct StockEvent
    {
        public string Description;
        public double MinChange;
        public double MaxChange;
        public StockEvent(string desc, double min, double max)
        {
            Description = desc;
            MinChange = min;
            MaxChange = max;
        }
    }
    public class Stock
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

        private static StockEvent[] events = new StockEvent[]
        {
            // ===== 호재 =====
            new StockEvent("신제품 출시 대성공", 10, 18),
            new StockEvent("글로벌 시장 진출 확정", 7, 12),
            new StockEvent("분기 실적 최고치 갱신", 5, 10),
            new StockEvent("AI 기술 상용화 성공", 8, 14),
            new StockEvent("정부 보조금 수혜", 4, 8),
            new StockEvent("해외 투자 대규모 유치", 6, 13),
            new StockEvent("산업규제 완화", 3, 7),
            new StockEvent("유명 인사 신규 영입", 2, 6),
            new StockEvent("특허권 분쟁 승소", 5, 11),
            new StockEvent("적대적 M&A 방어 성공", 4, 9),
            new StockEvent("경영진 대규모 자사주 매입", 6, 13),
            new StockEvent("합작 법인 설립", 3, 8),
            new StockEvent("배당금 대폭 인상", 5, 10),
            new StockEvent("공장 증설 완료", 2, 7),
            new StockEvent("주요지수 편입", 3, 8),
            // ===== 악재 =====
            new StockEvent("CEO 스캔들 발생", -16, -10),
            new StockEvent("안전성 문제로 리콜", -12, -6),
            new StockEvent("해외 규제 강화", -9, -5),
            new StockEvent("공장 화재 발생", -18, -12),
            new StockEvent("기술 유출 의혹", -10, -4),
            new StockEvent("대통령의 계엄령 선포", -20, -15),
            new StockEvent("금리 인상", -7, -2),
            new StockEvent("매출 급감", -13, -7),
            new StockEvent("주요 인사 이탈", -8, -3),
            new StockEvent("특허권 분쟁 패소", -9, -4),
            new StockEvent("노동자 대규모 파업", -12, -6),
            new StockEvent("원자재 가격 폭등", -10, -5),
            new StockEvent("배당금 삭감", -8, -2),
            new StockEvent("공정거래법 위반 적발", -11, -6),
            new StockEvent("고객 개인정보 유출", -15, -10)
        };


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
            StockEvent ev = events[rand.Next(events.Length)];

            double percentChange;
            if (ev.MinChange == ev.MaxChange)
                percentChange = ev.MinChange;
            else
                percentChange = rand.NextDouble() * (ev.MaxChange - ev.MinChange) + ev.MinChange;

            percentChange = Math.Round(percentChange, 2);

            ApplyEvent(ev.Description, percentChange);


        }
    }
}

