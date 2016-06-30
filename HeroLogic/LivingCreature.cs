using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HeroLogic.World;

namespace HeroLogic
{
    public class LivingCreature
    {
        public int MaximumHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public CreatureType Type { get; set; }
        public CreatureClass Difficulty { get; set; }
        public Areas Location { get; set; }


        public LivingCreature(int currentHitPoints, int maxHitPoints, CreatureType type, CreatureClass difficulty, Areas location)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maxHitPoints;
            Type = type;
            Difficulty = difficulty;
            Location = location;
        }
    }
}
