using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HeroLogic.World;

namespace HeroLogic
{
    public class Monster:LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public int LootID  { get; set; }
        public int Magic { get; set; }

        public Monster(int id, string name, string namePlural, int maxDamage, int rewardExp, int reward, int currentHitPoints, 
            int maxHitPoints, CreatureType type, CreatureClass difficulty, int lootID, int magic) : base (currentHitPoints,maxHitPoints, type, difficulty)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
            MaximumDamage = maxDamage;
            RewardExperiencePoints = rewardExp;
            RewardGold = reward;
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maxHitPoints;
            Type = type;
            Difficulty = difficulty;
            LootID = lootID;
            Magic = magic;
            
        }
    }
}
