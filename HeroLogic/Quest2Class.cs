using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HeroLogic.World;
namespace HeroLogic
{
    public class Quest2Class : Quest
    {
        public Who WhoQuest { get; set; }
        public Giver GiverQuest { get; set; }

        Quest2Class(int id, QuestType qtype, Areas areaQuest, int rewardGold, Who whoQuest, Giver giverQuest) : base(id, qtype, areaQuest, rewardGold)
        {
            ID = id;
            Qtype = qtype;
            AreaQuest = areaQuest;
            RewardGold = rewardGold;
            whoQuest = WhoQuest;
            GiverQuest = giverQuest;
        }
    }
}
