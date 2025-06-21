using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Growing
{
    public class Worker
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Income { get; set; }
        public int Interval { get; set; } // ms
        public bool IsHired { get; set; } = false;
        public int RequiredLevel { get; set; } // 고용 제한 레벨
        public int Level { get; set; } = 1;         // 알바 레벨
        public double IncomeMultiplier { get; set; } = 1.0;  // 수익 배율
        public Worker(string name, int cost, int income, int interval, int requiredLevel)
        {
            Name = name;
            Cost = cost;
            Income = income;
            Interval = interval;
            RequiredLevel = requiredLevel;
        }
        public int getCurrentIncome()
        {
            return (int)(Income * IncomeMultiplier);
        }

        public void levelUp()
        {
            Level++;
            IncomeMultiplier *= 1.2; // 알바 레벨업 시 수익 20% 증가
        }
    }
}
