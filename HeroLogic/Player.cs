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
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        public int Gold { get; set; }
        public string  Name { get; set; }
        public int ExperiecePoints { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public QuestOption QuestOp;
        
        public Player(int str, int dex, int inte, int chari, int gold, string name, int exp, int level,  QuestOption questOp,
            int currentHitPoints, int maxHitPoints, CreatureType type, CreatureClass difficulty) :base(currentHitPoints,maxHitPoints,type, difficulty)
        {
            Strength = str;
            Dexterity = dex;
            Intelligence = inte;
            Charisma = chari;
            Gold = gold;
            Name = name;
            ExperiecePoints = exp;
            Level = level;
            QuestOp = questOp;
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maxHitPoints;
            Type = type;
            Difficulty = difficulty;            
            Inventory = new List<InventoryItem>();
            

        }
    }
}
