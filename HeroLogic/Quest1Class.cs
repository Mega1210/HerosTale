using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HeroLogic.World;

namespace HeroLogic
{
    public class Quest1Class : Quest
    {
        public CreatureType CreatType { get; set; }
        public int MonsterID { get; set; }
        public string MonsterName { get; set; }

        public Quest1Class(QuestOption id, QuestType qtype, int locationID, string locationName, int rewardGold,
            CreatureType creatType, int monsterID, string monsterName) : base(id, qtype, locationID, locationName, rewardGold)
        {
            ID = id;
            Qtype = qtype;
            LocationID= locationID;
            LocationName = locationName;
            RewardGold = rewardGold;
            CreatType = creatType;
            MonsterID = monsterID;
            MonsterName = monsterName;
        }
    }
}
