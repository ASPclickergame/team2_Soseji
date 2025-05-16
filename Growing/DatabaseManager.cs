using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Growing
{
    [Serializable]
    public class PlayerData
    {
        public string name;
        public int money;
        public int level; 
        public int exp = 0;             //현재 경험치
        public int expNextLevel = 100;  //레벨업 필요 경험치
        public int clickIncome = 100;        //클릭당 수익
        public int expPerClick = 20;           // 경험치 상승량 퍼센트

        public List<Worker> workers = new List<Worker>();

        public PlayerData(string _name, int _money, int _level, int _exp, int _expNextLevel, int _clickIncome, int _expPerClick)
        {
            this.name = _name;
            this.money = _money;
            this.level = _level;
            this.exp = _exp;
            this.expNextLevel = _expNextLevel;
            this.clickIncome = _clickIncome;
            this.expPerClick = _expPerClick;
        }

        public void SetWorkers(List<Worker> _workers)
        {
            workers.Clear();
            workers = _workers;
        }
    }

    // data를 관리하는 함수
    class DatabaseManager
    {
        public string savePath = AppDomain.CurrentDomain.BaseDirectory; // 저장 경로
        private static DatabaseManager instance; // 싱글턴

        private PlayerData playerData;

        private DatabaseManager()
        {
            // 싱글턴 접근 금지!
        }

        public static DatabaseManager GetInstance()
        {
            // 싱글턴
            if (instance == null)
                instance = new DatabaseManager();

            return instance;
        }

        public void LoadingPlayerData()
        {
            playerData = new PlayerData("", 0, 0, 0, 0, 0, 0);
            playerData = LoadPlayerData();
        }

        public void SavePlayerData(PlayerData _data)
        {
            // _data파일을 save.csv로 저장

            string path = Path.Combine(savePath, "save.csv"); List<string> lines = new List<string>();

            // Player 정보
            lines.Add("[Player]");
            lines.Add($"{_data.name},{_data.money},{_data.level},{_data.exp},{_data.expNextLevel},{_data.clickIncome},{_data.expPerClick}");

            // Worker 정보
            lines.Add("[Workers]");
            List<string> workerStrings = new List<string>();
            foreach (var w in _data.workers)
            {
                workerStrings.Add($"{w.Name}|{w.Cost}|{w.Income}|{w.Interval}|{w.IsHired}|{w.RequiredLevel}");
            }
            lines.Add(string.Join(";", workerStrings));

            // 저장
            File.WriteAllLines(path, lines);
        }

        public PlayerData LoadPlayerData()
        {
            string path = Path.Combine(savePath, "save.csv");
            if (!File.Exists(path)) return null;

            string[] lines = File.ReadAllLines(path);
            PlayerData data = null;

            string currentSection = "";
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                if (line.StartsWith("[") && line.EndsWith("]"))
                {
                    currentSection = line.Trim();
                    continue;
                }

                switch (currentSection)
                {
                    case "[Player]":
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length >= 7)
                            {
                                string name = parts[0];
                                int money = int.Parse(parts[1]);
                                int level = int.Parse(parts[2]);
                                int exp = int.Parse(parts[3]);
                                int expNextLevel = int.Parse(parts[4]);
                                int clickIncome = int.Parse(parts[5]);
                                int expPerClick = int.Parse(parts[6]);

                                data = new PlayerData(name, money, level, exp, expNextLevel, clickIncome, expPerClick);
                            }
                            break;
                        }

                    case "[Workers]":
                        {
                            if (data == null) continue; // Player가 먼저 정의되어야 함

                            string[] workerParts = line.Split(';');
                            foreach (string wpStr in workerParts)
                            {
                                if (string.IsNullOrWhiteSpace(wpStr)) continue;

                                string[] wp = wpStr.Split('|');
                                if (wp.Length >= 6)
                                {
                                    Worker w = new Worker(
                                        wp[0],
                                        int.Parse(wp[1]),
                                        int.Parse(wp[2]),
                                        int.Parse(wp[3]),
                                        int.Parse(wp[5])
                                    );
                                    w.IsHired = bool.Parse(wp[4]);
                                    data.workers.Add(w);
                                }
                            }
                            break;
                        }

                        // 앞으로 확장할 수 있는 구조
                        // case "[Upgrades]": ...
                }
            }

            return data;
        }

        #region Get

        public int GetMoney()
        {
            return playerData.money;
        }

        public int GetLevel()
        {
            return playerData.level;
        }


        public int GetExp()
        {
            return playerData.exp;
        }

        public int GetExpNextLevel()
        {
            return playerData.expNextLevel;
        }

        public int GetClickIncome()
        {
            return playerData.clickIncome;
        }

        public int GetExpPerClick()
        {
            return playerData.expPerClick;
        }

        #endregion

        #region Set

        public void SetMoney(int _money)
        {
            playerData.money = _money;
        }

        #endregion

        public void PlusMoney(int _plus)
        {
            playerData.money += _plus;
        }
    }
}
