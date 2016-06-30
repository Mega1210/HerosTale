using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HeroLogic.World;

namespace HeroLogic
{
    public class Player:LivingCreature
    {        
        public int Strength { get; set; }
        public int Dexerity { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        public int Gold { get; set; }
        public string  Name { get; set; }
        public int ExperiecePoints { get; set; }
        public int Level { get; set; }
        public int ExperienceToLevel { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public byte QuestNr;

        public Player(int str, int dex, int inte, int chari, int gold, string name, int exp, int level, int expToLvl, 
            int currentHitPoints, int maxHitPoints, CreatureType type, CreatureClass difficulty, Areas location) :base(currentHitPoints,maxHitPoints,type, difficulty, location)
        {
            Strength = str;
            Dexerity = dex;
            Intelligence = inte;
            Charisma = chari;
            Gold = gold;
            Name = name;
            ExperiecePoints = exp;
            ExperienceToLevel = expToLvl;
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maxHitPoints;
            Type = type;
            Difficulty = difficulty;
            Location = location;
            Inventory = new List<InventoryItem>();
            

        }
    }
}
