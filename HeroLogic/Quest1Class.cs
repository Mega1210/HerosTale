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
        
        public int MonsterID { get; set; }
        public string MonsterName { get; set;}


        public Quest1Class(int locationID, string locationName, int rewardGold,
             int monsterID, string monsterName) : base(locationID, locationName, rewardGold)
        {         
            LocationID= locationID;
            LocationName = locationName;
            RewardGold = rewardGold;           
            MonsterID = monsterID;
            MonsterName = monsterName;
        }
    }
}
