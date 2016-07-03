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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Quest ID</param>
        /// <param name="qtype">Quest Type = SaveFromKidnap</param>
        /// <param name="location">Location ID</param>
        /// <param name="rewardGold">GOld</param>
        /// <param name="whoQuest">Who you need to save ID</param>
        /// <param name="giverQuest">Who gives the quest ID</param>
        public Quest2Class(int id, QuestType qtype, int locationID,string locationName, int rewardGold, string  whoQuestName, string giverQuestName) : base(id, qtype, locationID,locationName, rewardGold)
        {
            ID = id;
            Qtype = qtype;
            LocationID =locationID;
            LocationName = locationName;
            RewardGold = rewardGold;
            WhoQuestName = whoQuestName;
            GiverQuestName = giverQuestName;
        }
    }
}
