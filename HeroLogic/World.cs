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
        public static readonly List<CreatureLocations> CreatureLocations = new List<CreatureLocations>();


        public enum Areas : byte
        {
            Forest, Hills, Mountains, Desert, CastleRuins, TempleRuins

        }

        public enum CreatureType : byte
        {
            HumanPeaceful, HumanDanger, Animal, Monster

        }

        public enum CreatureClass : byte
        {
            Normal, Boss, Player

        }

        public enum QuestType : byte
        {
            Kill, Retrive, SaveKidnap, Caravan
        }

        public enum Who : byte
        {
            Sister, Mother, Brother, Father, Uncle, Aunt
        }

        public enum Giver : byte
        {
            Lord, NobleWoman, WeathlyMerchant, MerchantGuild
        }

        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_CLUB = 2;
        public const int ITEM_ID_SILVERSWORD = 3;
        public const int ITEM_ID_SWORD = 4;
        public const int ITEM_ID_AXE = 5;
        public const int ITEM_ID_RUBY_AMULET = 20;
        public const int ITEM_ID_EMERALD_AMULET = 21;
        public const int ITEM_ID_SAPPHIRE_AMULET = 22;
        public const int ITEM_ID_GOLDEN_WATCH = 23;
        public const int ITEM_ID_SILVER_WATCH = 24;
        public const int ITEM_ID_GOLDEN_NECKLACE = 25;
        public const int ITEM_ID_SILVER_NECKLACE = 26;
        public const int ITEM_ID_RING = 27;
        public const int ITEM_SANCTIFIED_CROSS = 28;
        public const int ITEM_SACRED_BOOK = 29;
        public const int ITEM_HOLY_TORCH = 30;
        public const int ITEM_ID_SMALL_HEALING_POTION = 100;
        public const int ITEM_ID_NORMAL_HEALING_POTION = 101;
        public const int ITEM_ID_LARGE_HEALING_POTION = 102;
        public const int ITEM_ID_SUPER_HEALING_POTION = 103;
        
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
        public const int MONSTER_ID_GIANT_SPIDER = 11;
        public const int MONSTER_ID_GIANT_BEETLE = 12;
        public const int MONSTER_ID_LYNX = 13;
        public const int MONSTER_ID_BANDIT = 30;
        public const int MONSTER_ID_THIEF = 31;
        public const int MONSTER_ID_BEGGAR = 32;
        public const int MONSTER_ID_PEASANT = 33;
        public const int MONSTER_ID_NOMAD = 34;
        public const int MONSTER_ID_RAIDERS = 35;        
        public const int MONSTER_ID_SCOUNDREL = 38;        
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
        public const int QUEST_ID_CARAVAN = 4;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateCreatureLocations();
            //PopulateQuests();        
        }

        private static void PopulateCreatureLocations()
        {
            CreatureLocations.Add(new CreatureLocations(1,Areas.Forest,1));
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5));
        }

        private static void PopulateMonsters()
        {
            Monsters.Add(new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3, CreatureType.Animal,CreatureClass.Normal));
            //Monsters.Add(new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3, CreatureType.Animal, CreatureClass.Normal, Areas.Everywhere));
            //Monsters.Add(new Monster(MONSTER_ID_GIANT_SPIDER, "Giant spider", 0, 5, 40, 10, 10, CreatureType.Animal, CreatureClass.Normal, Areas.Everywhere));
            

        }

        /* private static void PopulateQuests()
        {            
            Quests.Add(new Quest(QUEST_ID_KILLMONSTER,"Kill a monster",
                "There's a werewolf on the loose in the mountains. 200 Gold for the person that kills it",50,200,1));            
        }*/

        

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
