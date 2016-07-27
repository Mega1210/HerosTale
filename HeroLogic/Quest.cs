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

        public QuestOption QuestID { get; set; }
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public Monster QMonster{ get; set; }
        public Item QItem { get; set; }
        public string Kidnapped { get; set; }
        public string Giver { get; set; }



        public Quest( QuestOption questID, int locationID, string locationName, int rewardGold, Monster qMonster, Item qItem, 
            string kidnapped, string giver)
        {
            QuestID = questID;
            LocationID = locationID;
            LocationName = locationName;
            RewardGold = rewardGold;
            QMonster = qMonster;
            QItem = qItem;
            Kidnapped = kidnapped;
            Giver = giver;
        }
    }
}


