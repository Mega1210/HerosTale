using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroLogic
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public byte Type { get; set; }
        

        public Quest(int id, string name, string description, int rewardExperiencePoints, int reward, byte type)
        {
            ID = id;
            Name = name;
            Description = description;
            rewardExperiencePoints = RewardExperiencePoints;
            reward = RewardGold;
            Type = type;

        }
    }
}


