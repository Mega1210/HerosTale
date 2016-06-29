using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroLogic
{
    public class Monster:LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }        
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }

        public Monster(int id, string name, int maxDamage, int rewardExp, int reward, int currentHitPoints, int maxHitPoints) : base (currentHitPoints,maxHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maxDamage;
            RewardExperiencePoints = rewardExp;
            RewardGold = reward;
        }
    }
}
