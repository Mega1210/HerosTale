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

        public const int ITEM_ID_RUBY_AMULET = 100;
        public const int ITEM_ID_EMERALD_AMULET = 101;
        public const int ITEM_ID_SAPPHIRE_AMULET = 102;
        public const int ITEM_ID_GOLDEN_WATCH = 103;
        public const int ITEM_ID_SILVER_WATCH = 104;
        public const int ITEM_ID_GOLDEN_NECKLACE = 105;
        public const int ITEM_ID_SILVER_NECKLACE = 106;
        public const int ITEM_ID_RING = 107;

        public const int ITEM_SANCTIFIED_CROSS = 200;
        public const int ITEM_SACRED_BOOK = 201;
        public const int ITEM_HOLY_TORCH = 202;

        public const int ITEM_ID_SMALL_HEALING_POTION = 400;
        public const int ITEM_ID_NORMAL_HEALING_POTION = 401;
        public const int ITEM_ID_LARGE_HEALING_POTION = 402;
        public const int ITEM_ID_SUPER_HEALING_POTION = 403;


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
        public const int MONSTER_ID_BANDIT = 14;
        public const int MONSTER_ID_THIEF = 15;
        public const int MONSTER_ID_BEGGAR = 16;
        public const int MONSTER_ID_PEASANT = 17;
        public const int MONSTER_ID_TRAVELLER = 18;
        public const int MONSTER_ID_NOMAD = 19;
        public const int MONSTER_ID_RAIDERS = 20;
        public const int MONSTER_ID_SCOUNDREL = 21;
        public const int MONSTER_ID_HARPY = 22;
        public const int MONSTER_ID_WEREWOLF = 23;
        public const int MONSTER_ID_VAMPIRE = 24;
        public const int MONSTER_ID_LICH = 25;
        public const int MONSTER_ID_WYRM = 26;
        public const int MONSTER_ID_ZOMBIE = 27;
        public const int MONSTER_ID_SPECTRE = 28;
        public const int MONSTER_ID_SORCERER = 29;
        public const int MONSTER_ID_WITCH = 30;


        

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateCreatureLocations();
            //PopulateQuests();        
        }

        private static void PopulateCreatureLocations()
        {
            CreatureLocations.Add(new CreatureLocations(1, Areas.Forest, MONSTER_ID_RAT));
            CreatureLocations.Add(new CreatureLocations(2, Areas.CastleRuins, MONSTER_ID_RAT));
            CreatureLocations.Add(new CreatureLocations(3, Areas.TempleRuins, MONSTER_ID_RAT));
            CreatureLocations.Add(new CreatureLocations(4, Areas.Forest, MONSTER_ID_SNAKE));
            CreatureLocations.Add(new CreatureLocations(5, Areas.Hills, MONSTER_ID_SNAKE));
            CreatureLocations.Add(new CreatureLocations(6, Areas.Mountains, MONSTER_ID_SNAKE));
            CreatureLocations.Add(new CreatureLocations(7, Areas.Desert, MONSTER_ID_SNAKE));
            CreatureLocations.Add(new CreatureLocations(8, Areas.Forest, MONSTER_ID_RABIDDOG));
            CreatureLocations.Add(new CreatureLocations(9, Areas.Hills, MONSTER_ID_RABIDDOG));
            CreatureLocations.Add(new CreatureLocations(10, Areas.CastleRuins, MONSTER_ID_RABIDDOG));
            CreatureLocations.Add(new CreatureLocations(11, Areas.Forest, MONSTER_ID_WOLF));
            CreatureLocations.Add(new CreatureLocations(12, Areas.Hills, MONSTER_ID_WOLF));
            CreatureLocations.Add(new CreatureLocations(13, Areas.Mountains, MONSTER_ID_WOLF));
            CreatureLocations.Add(new CreatureLocations(14, Areas.Forest, MONSTER_ID_BEAR));
            CreatureLocations.Add(new CreatureLocations(15, Areas.Hills, MONSTER_ID_BEAR));
            CreatureLocations.Add(new CreatureLocations(16, Areas.Mountains, MONSTER_ID_BEAR));
            CreatureLocations.Add(new CreatureLocations(17, Areas.Forest, MONSTER_ID_GIANT_SCORPION));
            CreatureLocations.Add(new CreatureLocations(18, Areas.Desert, MONSTER_ID_GIANT_SCORPION));
            CreatureLocations.Add(new CreatureLocations(19, Areas.Forest, MONSTER_ID_CROW));
            CreatureLocations.Add(new CreatureLocations(20, Areas.Hills, MONSTER_ID_CROW));
            CreatureLocations.Add(new CreatureLocations(21, Areas.Mountains, MONSTER_ID_CROW));
            CreatureLocations.Add(new CreatureLocations(22, Areas.CastleRuins, MONSTER_ID_CROW));
            CreatureLocations.Add(new CreatureLocations(23, Areas.TempleRuins, MONSTER_ID_CROW));
            CreatureLocations.Add(new CreatureLocations(24, Areas.Forest, MONSTER_ID_PYTHON));
            CreatureLocations.Add(new CreatureLocations(25, Areas.Hills, MONSTER_ID_LION));
            CreatureLocations.Add(new CreatureLocations(26, Areas.Desert, MONSTER_ID_LION));
            CreatureLocations.Add(new CreatureLocations(27, Areas.Desert, MONSTER_ID_VULTURE));
            CreatureLocations.Add(new CreatureLocations(28, Areas.Forest, MONSTER_ID_GIANT_SPIDER));
            CreatureLocations.Add(new CreatureLocations(29, Areas.CastleRuins, MONSTER_ID_GIANT_SPIDER));
            CreatureLocations.Add(new CreatureLocations(30, Areas.TempleRuins, MONSTER_ID_GIANT_SPIDER));
            CreatureLocations.Add(new CreatureLocations(31, Areas.Hills, MONSTER_ID_GIANT_BEETLE));
            CreatureLocations.Add(new CreatureLocations(32, Areas.Desert, MONSTER_ID_GIANT_BEETLE));
            CreatureLocations.Add(new CreatureLocations(33, Areas.Forest, MONSTER_ID_LYNX));
            CreatureLocations.Add(new CreatureLocations(34, Areas.Hills, MONSTER_ID_LYNX));
            CreatureLocations.Add(new CreatureLocations(35, Areas.Desert, MONSTER_ID_LYNX));
            CreatureLocations.Add(new CreatureLocations(36, Areas.Forest, MONSTER_ID_BANDIT));
            CreatureLocations.Add(new CreatureLocations(37, Areas.Hills, MONSTER_ID_BANDIT));
            CreatureLocations.Add(new CreatureLocations(38, Areas.Mountains, MONSTER_ID_BANDIT));
            CreatureLocations.Add(new CreatureLocations(39, Areas.Desert, MONSTER_ID_BANDIT));
            CreatureLocations.Add(new CreatureLocations(40, Areas.Forest, MONSTER_ID_THIEF));
            CreatureLocations.Add(new CreatureLocations(41, Areas.CastleRuins, MONSTER_ID_THIEF));
            CreatureLocations.Add(new CreatureLocations(42, Areas.TempleRuins, MONSTER_ID_THIEF));
            CreatureLocations.Add(new CreatureLocations(43, Areas.Hills, MONSTER_ID_BEGGAR));
            CreatureLocations.Add(new CreatureLocations(44, Areas.CastleRuins, MONSTER_ID_BEGGAR));
            CreatureLocations.Add(new CreatureLocations(45, Areas.Forest, MONSTER_ID_PEASANT));
            CreatureLocations.Add(new CreatureLocations(46, Areas.Hills, MONSTER_ID_PEASANT));
            CreatureLocations.Add(new CreatureLocations(47, Areas.Forest, MONSTER_ID_TRAVELLER));
            CreatureLocations.Add(new CreatureLocations(48, Areas.Hills, MONSTER_ID_TRAVELLER));
            CreatureLocations.Add(new CreatureLocations(49, Areas.Mountains, MONSTER_ID_TRAVELLER));
            CreatureLocations.Add(new CreatureLocations(50, Areas.Desert, MONSTER_ID_TRAVELLER));
            CreatureLocations.Add(new CreatureLocations(51, Areas.CastleRuins, MONSTER_ID_TRAVELLER));
            CreatureLocations.Add(new CreatureLocations(52, Areas.TempleRuins, MONSTER_ID_TRAVELLER));
            CreatureLocations.Add(new CreatureLocations(53, Areas.Hills, MONSTER_ID_NOMAD));
            CreatureLocations.Add(new CreatureLocations(54, Areas.Desert, MONSTER_ID_NOMAD));
            CreatureLocations.Add(new CreatureLocations(55, Areas.Desert, MONSTER_ID_RAIDERS));
            CreatureLocations.Add(new CreatureLocations(56, Areas.CastleRuins, MONSTER_ID_RAIDERS));
            CreatureLocations.Add(new CreatureLocations(57, Areas.TempleRuins, MONSTER_ID_RAIDERS));
            CreatureLocations.Add(new CreatureLocations(58, Areas.Hills, MONSTER_ID_SCOUNDREL));
            CreatureLocations.Add(new CreatureLocations(59, Areas.Desert, MONSTER_ID_SCOUNDREL));
            CreatureLocations.Add(new CreatureLocations(60, Areas.Mountains, MONSTER_ID_HARPY));
            CreatureLocations.Add(new CreatureLocations(61, Areas.Desert, MONSTER_ID_HARPY));
            CreatureLocations.Add(new CreatureLocations(62, Areas.Forest, MONSTER_ID_WEREWOLF));
            CreatureLocations.Add(new CreatureLocations(63, Areas.CastleRuins, MONSTER_ID_WEREWOLF));
            CreatureLocations.Add(new CreatureLocations(64, Areas.TempleRuins, MONSTER_ID_WEREWOLF));
            CreatureLocations.Add(new CreatureLocations(65, Areas.CastleRuins, MONSTER_ID_VAMPIRE));
            CreatureLocations.Add(new CreatureLocations(66, Areas.TempleRuins, MONSTER_ID_VAMPIRE));
            CreatureLocations.Add(new CreatureLocations(67, Areas.TempleRuins, MONSTER_ID_LICH));
            CreatureLocations.Add(new CreatureLocations(68, Areas.Forest, MONSTER_ID_WYRM));
            CreatureLocations.Add(new CreatureLocations(69, Areas.Mountains, MONSTER_ID_WYRM));
            CreatureLocations.Add(new CreatureLocations(70, Areas.CastleRuins, MONSTER_ID_WYRM));
            CreatureLocations.Add(new CreatureLocations(71, Areas.TempleRuins, MONSTER_ID_WYRM));
            CreatureLocations.Add(new CreatureLocations(72, Areas.TempleRuins, MONSTER_ID_ZOMBIE));
            CreatureLocations.Add(new CreatureLocations(73, Areas.CastleRuins, MONSTER_ID_SPECTRE));
            CreatureLocations.Add(new CreatureLocations(74, Areas.TempleRuins, MONSTER_ID_SPECTRE));
            CreatureLocations.Add(new CreatureLocations(75, Areas.CastleRuins, MONSTER_ID_SORCERER));
            CreatureLocations.Add(new CreatureLocations(76, Areas.TempleRuins, MONSTER_ID_SORCERER));
            CreatureLocations.Add(new CreatureLocations(77, Areas.Forest, MONSTER_ID_WITCH));
            CreatureLocations.Add(new CreatureLocations(78, Areas.CastleRuins, MONSTER_ID_WITCH));

        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty Sword", "Rusty Swords", 1, 5));
            Items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 3, 10));
            Items.Add(new Weapon(ITEM_ID_SILVERSWORD, "Silver Sword", "Silver Swords", 80, 100));
            Items.Add(new Weapon(ITEM_ID_SWORD, "Sword", "Swords", 30, 60));
            Items.Add(new Weapon(ITEM_ID_AXE, "Axe", "Axes", 25, 85));

            Items.Add(new Item(ITEM_ID_RUBY_AMULET, "Ruby Amulet", "Ruby Amulets"));
            Items.Add(new Item(ITEM_ID_EMERALD_AMULET, "Emerald Amulet", "Emerald Amulets"));
            Items.Add(new Item(ITEM_ID_SAPPHIRE_AMULET, "Sapphire Amulet", "Sapphire Amulets"));
            Items.Add(new Item(ITEM_ID_GOLDEN_WATCH, "Golden Watch", "Golden Watches"));
            Items.Add(new Item(ITEM_ID_SILVER_WATCH, "Silver Watch", "Silver Watches"));
            Items.Add(new Item(ITEM_ID_GOLDEN_NECKLACE, "Golden Necklace", "Golden Necklaces"));
            Items.Add(new Item(ITEM_ID_SILVER_NECKLACE, "Silver Necklace", "Silver Necklaces"));
            Items.Add(new Item(ITEM_ID_RING, "Ring", "Rings"));

            Items.Add(new Item(ITEM_SANCTIFIED_CROSS, "Sanctified Cross", "Sanctified Crosses"));
            Items.Add(new Item(ITEM_SACRED_BOOK, "Sacred Book", "Sacred Books"));
            Items.Add(new Item(ITEM_HOLY_TORCH, "Holy Torch", "Holy Torches"));

            Items.Add(new HealingPotion(ITEM_ID_SMALL_HEALING_POTION, "Small Healing Potion", "Small Healing Potions", 20));
            Items.Add(new HealingPotion(ITEM_ID_NORMAL_HEALING_POTION, "Normal Healing Potion", "Normal Healing Potions", 100));
            Items.Add(new HealingPotion(ITEM_ID_LARGE_HEALING_POTION, "Large Healing Potion", "Large Healing Potions", 200));
            Items.Add(new HealingPotion(ITEM_ID_SUPER_HEALING_POTION, "Super Healing Potion", "Super Healing Potions", 500));

        }

        private static void PopulateMonsters()
        {
            Monsters.Add(new Monster(MONSTER_ID_RAT, "Rat","Rats", 5, 25, 40, 20, 20, CreatureType.Animal, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_SNAKE, "Snake", "Snakes", 8, 40, 60, 20, 20, CreatureType.Animal, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_RABIDDOG, "Rabid Dog", "Rabid Dogs", 12, 60, 90, 50, 50, CreatureType.Animal, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_WOLF, "Wolf", "Wolves", 20, 100, 150, 50, 50, CreatureType.Animal, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_BEAR, "Bear", "Bears", 25, 125, 190, 75, 75, CreatureType.Animal, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_GIANT_SCORPION, "Giant Scorpion", "Giant Scorpions", 25, 125, 190, 120, 120, CreatureType.Animal, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_CROW, "Crow", "Crows", 15, 75, 120, 75, 75, CreatureType.Animal, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_PYTHON, "Python", "Pythons", 25, 125, 190, 120, 120, CreatureType.Animal, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_LION, "Lion", "Lions", 30, 150, 230, 200, 200, CreatureType.Animal, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_VULTURE, "Vulture", "Vultures", 30, 150, 230, 150, 150, CreatureType.Animal, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_GIANT_SPIDER, "Giant Spider", "Giant Spiders", 25, 125, 190, 150, 150, CreatureType.Animal, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_GIANT_BEETLE, "Giant Beetle", "Giant Beetles", 20, 100, 150, 120, 120, CreatureType.Animal, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_LYNX, "Lynx", "Lynxes", 30, 150, 230, 200, 200, CreatureType.Animal, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_BANDIT, "Bandit", "Bandits", 45, 225, 340, 500, 500, CreatureType.HumanDanger, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_THIEF, "Thief", "Thieves", 45, 225, 340, 500, 500, CreatureType.HumanDanger, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_BEGGAR, "Beggar", "Beggars", 8, 40, 60, 250, 250, CreatureType.HumanPeaceful, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_PEASANT, "Peasant", "Peasants", 10, 50, 80, 350, 350, CreatureType.HumanPeaceful, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_TRAVELLER, "Traveller", "Travellers", 15, 75, 120, 500, 500, CreatureType.HumanPeaceful, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_NOMAD, "Nomad", "Nomads", 15, 75, 120, 500, 500, CreatureType.HumanPeaceful, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_RAIDERS, "Raiders", "Raiders", 60, 300, 450, 600, 600, CreatureType.HumanDanger, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_SCOUNDREL, "Scoundrel", "Scoundrels", 50, 250, 380, 600, 600, CreatureType.HumanDanger, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_HARPY, "Harpy", "Harpies", 100, 500, 750, 800, 800, CreatureType.Monster, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_WEREWOLF, "Werewolf", "Werewolves", 120, 600, 900, 1000, 1000, CreatureType.Monster, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_VAMPIRE, "Vampire", "Vampires", 150, 750, 1130, 1000, 1000, CreatureType.Monster, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_LICH, "Lich", "Liches", 175, 875, 1320, 1000, 1000, CreatureType.Monster, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_WYRM, "Wyrm", "Wyrms", 200, 1000, 1500, 2000, 2000, CreatureType.Monster, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_ZOMBIE, "Zombie", "Zombies", 110, 550, 830, 1200, 1200, CreatureType.Monster, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_SPECTRE, "Spectre", "Spectres", 110, 550, 830, 1200, 1200, CreatureType.Monster, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_SORCERER, "Sorcerer", "Sorcerers", 110, 550, 830, 1400, 1400, CreatureType.Monster, CreatureClass.Normal));
            Monsters.Add(new Monster(MONSTER_ID_WITCH, "Witch", "Witches", 110, 550, 830, 1400, 1400, CreatureType.Monster, CreatureClass.Normal));
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

      /*  public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }*/

        
    }
}
