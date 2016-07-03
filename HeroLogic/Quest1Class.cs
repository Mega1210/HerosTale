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

        public Quest1Class(int id, QuestType qtype, Areas areaQuest, int rewardGold,
            CreatureType creatType, int monsterID) : base(id, qtype, areaQuest, rewardGold)
        {
            ID = id;
            Qtype = qtype;
            AreaQuest = areaQuest;
            RewardGold = rewardGold;
            CreatType = creatType;
            MonsterID = monsterID;
        }
    }
}
