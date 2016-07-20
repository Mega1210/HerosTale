﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HeroLogic.World;
namespace HeroLogic
{
    public class Quest3Class:Quest
    {
        public string GiverQuestName { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }

        public Quest3Class(int locationID, string locationName, int rewardGold, 
            string giverQuestName, int itemID, string itemName) : base(locationID,locationName, rewardGold)
        {

            LocationID = locationID;
            LocationName = locationName;
            RewardGold = rewardGold;            
            GiverQuestName = giverQuestName;
            ItemID = itemID;
            ItemName = itemName;
        }
    }
}
