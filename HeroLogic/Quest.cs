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
        //public string Name { get; set; }
        //public string Description { get; set; }
        public QuestType Qtype { get; set; }
        public CreatureType CreatType { get; set; }
        public Areas AreaQuest { get; set; }
        public Who WhoQuest { get; set; }
        public Giver GiverQuestr { get; set; }
        public int ItemQuestID { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        
        

        public Quest(int id, QuestType qtype, CreatureType creatType, Areas areaQuest, Who whoquest, Giver giverquest,
            int itemQuestId, int rewardExperiencePoints, int rewardGold)
        {
            ID = id;
            Qtype = qtype;
            CreatType = creatType;
            AreaQuest = areaQuest;
            WhoQuest = whoquest;
            GiverQuestr = giverquest;
            ItemQuestID = itemQuestId;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;


        }
    }
}


