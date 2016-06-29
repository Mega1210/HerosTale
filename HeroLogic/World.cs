using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroLogic
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        

        public const int ITEM_ID_RUSTY_SWORD = 1;        
        public const int ITEM_ID_CLUB = 2;
        public const int ITEM_ID_HEALING_POTION = 3;
        public const int ITEM_ID_SILVERSWORD = 4;
        public const int ITEM_ID_SWORD = 5;
        public const int ITEM_ID_AXE = 6;
        public const int ITEM_ID_AMULET = 8;
        public const int ITEM_ID_WATCH = 9;
        public const int ITEM_ID_NECKLACE = 10;
        public const int ITEM_ID_RING = 11;


        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_RABIDDOG = 3;
        public const int MONSTER_ID_WOLF = 4;
        public const int MONSTER_ID_BEAR = 5;
        public const int MONSTER_ID_GIANT_SCORPION = 6;
        public const int MONSTER_ID_CROW = 7;
        public const int MONSTER_ID_PYTHON = 8;
        public const int MONSTER_ID_LION = 9;
        public const int MONSTER_ID_VULTURE = 10;
        public const int MONSTER_ID_GIANT_SPIDER = 10;
        public const int MONSTER_ID_BANDIT = 30;
        public const int MONSTER_ID_THIEF = 31;
        public const int MONSTER_ID_BEGGAR = 32;
        public const int MONSTER_ID_PEASANT = 33;
        public const int MONSTER_ID_BANDITLEADER = 34;
        public const int MONSTER_ID_RAIDERS = 35;
        public const int MONSTER_ID_RAIDERSLEADER = 36;
        public const int MONSTER_ID_MADALCHEMYST = 37;
        public const int MONSTER_ID_SCOUNDREL = 38;
        public const int MONSTER_ID_THIEFLEADER = 39;
        public const int MONSTER_ID_HARPY = 100;
        public const int MONSTER_ID_WEREWOLF = 101;
        public const int MONSTER_ID_VAMPIRE = 102;
        public const int MONSTER_ID_LICH = 103;
        public const int MONSTER_ID_WYRM = 104;
        public const int MONSTER_ID_ZOMBIE = 105;
        public const int MONSTER_ID_SPECTRE = 106;
        public const int MONSTER_ID_SORCERER = 107;
        public const int MONSTER_ID_WITCH = 108;

        public const int QUEST_ID_KILLMONSTER = 1;
        public const int QUEST_ID_KILLHUMAN = 2;
        public const int QUEST_ID_RECOVERITEM = 3;
        public const int QUEST_ID_WORKLORD = 4;
        public const int QUEST_ID_CARAVAN = 4;



        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
        
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5));
        
        }

        private static void PopulateMonsters()
        {
            Monsters.Add(new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3));
            Monsters.Add(new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3));
            Monsters.Add(new Monster(MONSTER_ID_GIANT_SPIDER, "Giant spider", 0, 5, 40, 10, 10));
            

        }

        private static void PopulateQuests()
        {            
            Quests.Add(new Quest(QUEST_ID_KILLMONSTER,"Kill a monster",
                "There's a werewolf on the loose in the mountains. 200 Gold for the person that kills it",50,200,1));            
        }

        

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        
    }
}
