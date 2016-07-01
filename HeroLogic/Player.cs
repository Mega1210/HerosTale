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
        public List<InventoryItem> Inventory { get; set; }
        public byte QuestNr;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="dex"></param>
        /// <param name="inte"></param>
        /// <param name="chari"></param>
        /// <param name="gold"></param>
        /// <param name="name"></param>
        /// <param name="exp"></param>
        /// <param name="level"></param>        
        /// <param name="currentHitPoints"></param>
        /// <param name="maxHitPoints"></param>
        /// <param name="type"></param>
        /// <param name="difficulty"></param>
        public Player(int str, int dex, int inte, int chari, int gold, string name, int exp, int level,  
            int currentHitPoints, int maxHitPoints, CreatureType type, CreatureClass difficulty) :base(currentHitPoints,maxHitPoints,type, difficulty)
        {
            Strength = str;
            Dexerity = dex;
            Intelligence = inte;
            Charisma = chari;
            Gold = gold;
            Name = name;
            ExperiecePoints = exp;
            Level = level;
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maxHitPoints;
            Type = type;
            Difficulty = difficulty;            
            Inventory = new List<InventoryItem>();
            

        }
    }
}
