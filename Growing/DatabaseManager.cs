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
        public int exp;
        public int expNextLevel;
        

        public PlayerData(string _name, int _money, int _level, int _exp, int _expNextLevel)
        {
            this.name = _name;
            this.money = _money;
            this.level = _level;
            this.exp = _exp;
            this.expNextLevel = _expNextLevel;
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
            playerData = new PlayerData("", 0, 0, 0, 0);
            playerData = LoadPlayerData();
        }

        public void SavePlayerData(PlayerData _data)
        {
            // _data파일을 save.csv로 저장

            string path = Path.Combine(savePath, "save.csv");
            string line = $"{_data.name},{_data.money}, {_data.level}, {_data.exp}, {_data.expNextLevel}";

            File.WriteAllText(path, line);
        }

        public PlayerData LoadPlayerData()
        {
            string path = Path.Combine(savePath, "save.csv");
            if (!File.Exists(path)) return null;

            string line = File.ReadAllText(path);
            string[] parts = line.Split(',');

            return new PlayerData(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));
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
