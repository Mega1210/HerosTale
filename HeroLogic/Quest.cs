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
        
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        
        

        public Quest( int locationID, string locationName, int rewardGold)
        {
         
            LocationID = locationID;
            LocationName = locationName;
            RewardGold = rewardGold;


        }
    }
}


