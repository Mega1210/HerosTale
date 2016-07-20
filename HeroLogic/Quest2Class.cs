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
        public string WhoQuestName { get; set; }
        public string GiverQuestName { get; set; }

        public Quest2Class(int locationID,string locationName, int rewardGold, string  whoQuestName, string giverQuestName) : base(locationID,locationName, rewardGold)
        {

            LocationID =locationID;
            LocationName = locationName;
            RewardGold = rewardGold;
            WhoQuestName = whoQuestName;
            GiverQuestName = giverQuestName;
        }
    }
}
