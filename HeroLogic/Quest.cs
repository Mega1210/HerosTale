using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HeroLogic.World;

namespace HeroLogic
{
    public class Quest
    {
        public int ID { get; set; }      
        public QuestType Qtype { get; set; }
        public Areas AreaQuest { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        
        

        public Quest(int id, QuestType qtype, Areas areaQuest, int rewardGold)
        {
            ID = id;
            Qtype = qtype;
            AreaQuest = areaQuest;            
            RewardGold = rewardGold;


        }
    }
}


