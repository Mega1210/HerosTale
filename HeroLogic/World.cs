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
        public static readonly List<QuestGiver> QuestGivers = new List<QuestGiver>();
        public static readonly List<QuestWho> QuestWhois = new List<QuestWho>();
        public static readonly List<WorldLocation> WorldLocations = new List<WorldLocation>();
        public static Random rnd = new Random();

        public enum EscAvoid
        {
            AvoidAmbush, Ambush, AvoidCombat, FleeCombat
        }

        public enum ButtonChoice
        {
            Button1, Button2, Button3, Button4
        }


        public enum QuestOption
        {
            Quest1, Quest2, Quest3
        }

        public enum GamePhase
        {
            Journey, BossEncounter, Shop, Caravan, Marrakesh, Tavern
        }

        public enum InitialMenuChoice
        {
            Quest1,Quest2,Quest3,Caravan,Shop
        }

        public enum EventJourney
        {
            Nothing, Approach, Noise
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

        public const int LOC_FOREST = 1;
        public const int LOC_HILLS = 2;
        public const int LOC_MOUNTAINS = 3;
        public const int LOC_DESERT = 4;
        public const int LOC_CASTLERUINS=5;
        public const int LOC_TEMPLERUINS = 6;
                    
        public const int GIVER_NOBLEMAN = 1;
        public const int GIVER_NOBLEWOMAN = 2;
        public const int GIVER_SPICEMERCHANT = 3;
        public const int GIVER_DUCHESS = 4;
        public const int GIVER_DUKE = 5;
        public const int GIVER_WEAPONMERCHANT = 6;
        public const int GIVER_JEWELMERCHANT = 7;
        public const int GIVER_PRIEST = 8;
        public const int GIVER_PRIESTESS = 9;
        
        public const int WHO_SISTER= 1;
        public const int WHO_MOTHER= 2;
        public const int WHO_BROTHER = 3;
        public const int WHO_FATHER = 4;
        public const int WHO_UNCLE = 5;
        public const int WHO_AUNT= 6;
        
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
            PopulateLocations();
            PopulateQGivers();
            PopulateWho();
        }

        private static void PopulateCreatureLocations()
        {
            CreatureLocations.Add(new CreatureLocations(1, LOC_FOREST, MONSTER_ID_RAT));
            CreatureLocations.Add(new CreatureLocations(2, LOC_CASTLERUINS, MONSTER_ID_RAT));
            CreatureLocations.Add(new CreatureLocations(3, LOC_TEMPLERUINS, MONSTER_ID_RAT));
            CreatureLocations.Add(new CreatureLocations(4, LOC_FOREST, MONSTER_ID_SNAKE));
            CreatureLocations.Add(new CreatureLocations(5, LOC_HILLS, MONSTER_ID_SNAKE));
            CreatureLocations.Add(new CreatureLocations(6, LOC_MOUNTAINS, MONSTER_ID_SNAKE));
            CreatureLocations.Add(new CreatureLocations(7, LOC_DESERT, MONSTER_ID_SNAKE));
            CreatureLocations.Add(new CreatureLocations(8, LOC_FOREST, MONSTER_ID_RABIDDOG));
            CreatureLocations.Add(new CreatureLocations(9, LOC_HILLS, MONSTER_ID_RABIDDOG));
            CreatureLocations.Add(new CreatureLocations(10, LOC_CASTLERUINS, MONSTER_ID_RABIDDOG));
            CreatureLocations.Add(new CreatureLocations(11, LOC_FOREST, MONSTER_ID_WOLF));
            CreatureLocations.Add(new CreatureLocations(12, LOC_HILLS, MONSTER_ID_WOLF));
            CreatureLocations.Add(new CreatureLocations(13, LOC_MOUNTAINS, MONSTER_ID_WOLF));
            CreatureLocations.Add(new CreatureLocations(14, LOC_FOREST, MONSTER_ID_BEAR));
            CreatureLocations.Add(new CreatureLocations(15, LOC_HILLS, MONSTER_ID_BEAR));
            CreatureLocations.Add(new CreatureLocations(16, LOC_MOUNTAINS, MONSTER_ID_BEAR));
            CreatureLocations.Add(new CreatureLocations(17, LOC_FOREST, MONSTER_ID_GIANT_SCORPION));
            CreatureLocations.Add(new CreatureLocations(18, LOC_DESERT, MONSTER_ID_GIANT_SCORPION));
            CreatureLocations.Add(new CreatureLocations(19, LOC_FOREST, MONSTER_ID_CROW));
            CreatureLocations.Add(new CreatureLocations(20, LOC_HILLS, MONSTER_ID_CROW));
            CreatureLocations.Add(new CreatureLocations(21, LOC_MOUNTAINS, MONSTER_ID_CROW));
            CreatureLocations.Add(new CreatureLocations(22, LOC_CASTLERUINS, MONSTER_ID_CROW));
            CreatureLocations.Add(new CreatureLocations(23, LOC_TEMPLERUINS, MONSTER_ID_CROW));
            CreatureLocations.Add(new CreatureLocations(24, LOC_FOREST, MONSTER_ID_PYTHON));
            CreatureLocations.Add(new CreatureLocations(25, LOC_HILLS, MONSTER_ID_LION));
            CreatureLocations.Add(new CreatureLocations(26, LOC_DESERT, MONSTER_ID_LION));
            CreatureLocations.Add(new CreatureLocations(27, LOC_DESERT, MONSTER_ID_VULTURE));
            CreatureLocations.Add(new CreatureLocations(28, LOC_FOREST, MONSTER_ID_GIANT_SPIDER));
            CreatureLocations.Add(new CreatureLocations(29, LOC_CASTLERUINS, MONSTER_ID_GIANT_SPIDER));
            CreatureLocations.Add(new CreatureLocations(30, LOC_TEMPLERUINS, MONSTER_ID_GIANT_SPIDER));
            CreatureLocations.Add(new CreatureLocations(31, LOC_HILLS, MONSTER_ID_GIANT_BEETLE));
            CreatureLocations.Add(new CreatureLocations(32, LOC_DESERT, MONSTER_ID_GIANT_BEETLE));
            CreatureLocations.Add(new CreatureLocations(33, LOC_FOREST, MONSTER_ID_LYNX));
            CreatureLocations.Add(new CreatureLocations(34, LOC_HILLS, MONSTER_ID_LYNX));
            CreatureLocations.Add(new CreatureLocations(35, LOC_DESERT, MONSTER_ID_LYNX));
            CreatureLocations.Add(new CreatureLocations(36, LOC_FOREST, MONSTER_ID_BANDIT));
            CreatureLocations.Add(new CreatureLocations(37, LOC_HILLS, MONSTER_ID_BANDIT));
            CreatureLocations.Add(new CreatureLocations(38, LOC_MOUNTAINS, MONSTER_ID_BANDIT));
            CreatureLocations.Add(new CreatureLocations(39, LOC_DESERT, MONSTER_ID_BANDIT));
            CreatureLocations.Add(new CreatureLocations(40, LOC_FOREST, MONSTER_ID_THIEF));
            CreatureLocations.Add(new CreatureLocations(41, LOC_CASTLERUINS, MONSTER_ID_THIEF));
            CreatureLocations.Add(new CreatureLocations(42, LOC_TEMPLERUINS, MONSTER_ID_THIEF));
            CreatureLocations.Add(new CreatureLocations(43, LOC_HILLS, MONSTER_ID_BEGGAR));
            CreatureLocations.Add(new CreatureLocations(44, LOC_CASTLERUINS, MONSTER_ID_BEGGAR));
            CreatureLocations.Add(new CreatureLocations(45, LOC_FOREST, MONSTER_ID_PEASANT));
            CreatureLocations.Add(new CreatureLocations(46, LOC_HILLS, MONSTER_ID_PEASANT));
            CreatureLocations.Add(new CreatureLocations(47, LOC_FOREST, MONSTER_ID_TRAVELLER));
            CreatureLocations.Add(new CreatureLocations(48, LOC_HILLS, MONSTER_ID_TRAVELLER));
            CreatureLocations.Add(new CreatureLocations(49, LOC_MOUNTAINS, MONSTER_ID_TRAVELLER));
            CreatureLocations.Add(new CreatureLocations(50, LOC_DESERT, MONSTER_ID_TRAVELLER));
            CreatureLocations.Add(new CreatureLocations(51, LOC_CASTLERUINS, MONSTER_ID_TRAVELLER));
            CreatureLocations.Add(new CreatureLocations(52, LOC_TEMPLERUINS, MONSTER_ID_TRAVELLER));
            CreatureLocations.Add(new CreatureLocations(53, LOC_HILLS, MONSTER_ID_NOMAD));
            CreatureLocations.Add(new CreatureLocations(54, LOC_DESERT, MONSTER_ID_NOMAD));
            CreatureLocations.Add(new CreatureLocations(55, LOC_DESERT, MONSTER_ID_RAIDERS));
            CreatureLocations.Add(new CreatureLocations(56, LOC_CASTLERUINS, MONSTER_ID_RAIDERS));
            CreatureLocations.Add(new CreatureLocations(57, LOC_TEMPLERUINS, MONSTER_ID_RAIDERS));
            CreatureLocations.Add(new CreatureLocations(58, LOC_HILLS, MONSTER_ID_SCOUNDREL));
            CreatureLocations.Add(new CreatureLocations(59, LOC_DESERT, MONSTER_ID_SCOUNDREL));
            CreatureLocations.Add(new CreatureLocations(60, LOC_MOUNTAINS, MONSTER_ID_HARPY));
            CreatureLocations.Add(new CreatureLocations(61, LOC_DESERT, MONSTER_ID_HARPY));
            CreatureLocations.Add(new CreatureLocations(62, LOC_FOREST, MONSTER_ID_WEREWOLF));
            CreatureLocations.Add(new CreatureLocations(63, LOC_CASTLERUINS, MONSTER_ID_WEREWOLF));
            CreatureLocations.Add(new CreatureLocations(64, LOC_TEMPLERUINS, MONSTER_ID_WEREWOLF));
            CreatureLocations.Add(new CreatureLocations(65, LOC_CASTLERUINS, MONSTER_ID_VAMPIRE));
            CreatureLocations.Add(new CreatureLocations(66, LOC_TEMPLERUINS, MONSTER_ID_VAMPIRE));
            CreatureLocations.Add(new CreatureLocations(67, LOC_TEMPLERUINS, MONSTER_ID_LICH));
            CreatureLocations.Add(new CreatureLocations(68, LOC_FOREST, MONSTER_ID_WYRM));
            CreatureLocations.Add(new CreatureLocations(69, LOC_MOUNTAINS, MONSTER_ID_WYRM));
            CreatureLocations.Add(new CreatureLocations(70, LOC_CASTLERUINS, MONSTER_ID_WYRM));
            CreatureLocations.Add(new CreatureLocations(71, LOC_TEMPLERUINS, MONSTER_ID_WYRM));
            CreatureLocations.Add(new CreatureLocations(72, LOC_TEMPLERUINS, MONSTER_ID_ZOMBIE));
            CreatureLocations.Add(new CreatureLocations(73, LOC_CASTLERUINS, MONSTER_ID_SPECTRE));
            CreatureLocations.Add(new CreatureLocations(74, LOC_TEMPLERUINS, MONSTER_ID_SPECTRE));
            CreatureLocations.Add(new CreatureLocations(75, LOC_CASTLERUINS, MONSTER_ID_SORCERER));
            CreatureLocations.Add(new CreatureLocations(76, LOC_TEMPLERUINS, MONSTER_ID_SORCERER));
            CreatureLocations.Add(new CreatureLocations(77, LOC_FOREST, MONSTER_ID_WITCH));
            CreatureLocations.Add(new CreatureLocations(78, LOC_CASTLERUINS, MONSTER_ID_WITCH));

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

        private static void PopulateLocations()
        {
            WorldLocations.Add(new WorldLocation(LOC_CASTLERUINS, "Castle Ruins"));
            WorldLocations.Add(new WorldLocation(LOC_DESERT, "Desert"));
            WorldLocations.Add(new WorldLocation(LOC_FOREST, "Forest"));
            WorldLocations.Add(new WorldLocation(LOC_HILLS, "Hills"));
            WorldLocations.Add(new WorldLocation(LOC_MOUNTAINS, "Mountains"));
            WorldLocations.Add(new WorldLocation(LOC_TEMPLERUINS, "Temple Ruins"));
        }

        private static void PopulateWho()
        {
            QuestWhois.Add(new QuestWho(WHO_AUNT, "Aunt"));
            QuestWhois.Add(new QuestWho(WHO_BROTHER, "Brother"));
            QuestWhois.Add(new QuestWho(WHO_FATHER, "Father"));
            QuestWhois.Add(new QuestWho(WHO_MOTHER, "Mother"));
            QuestWhois.Add(new QuestWho(WHO_SISTER, "Sister"));
            QuestWhois.Add(new QuestWho(WHO_UNCLE, "Uncle"));
        }

        private static void PopulateQGivers()
        {
            QuestGivers.Add(new QuestGiver(GIVER_NOBLEMAN, "Noble Man"));
            QuestGivers.Add(new QuestGiver(GIVER_NOBLEWOMAN, "Noble Woman"));
            QuestGivers.Add(new QuestGiver(GIVER_SPICEMERCHANT, "Wealthy Spice Merchant"));
            QuestGivers.Add(new QuestGiver(GIVER_DUCHESS, "Duchess"));
            QuestGivers.Add(new QuestGiver(GIVER_DUKE, "Duke"));
            QuestGivers.Add(new QuestGiver(GIVER_WEAPONMERCHANT, "Wealthy Weapon Merchant"));
            QuestGivers.Add(new QuestGiver(GIVER_JEWELMERCHANT, "Wealthy Jewels Merchant"));
            QuestGivers.Add(new QuestGiver(GIVER_PRIEST, "Priest"));
            QuestGivers.Add(new QuestGiver(GIVER_PRIESTESS, "Priestess"));


        }
              
        public static IEnumerable<int> MonstersList()
        {
            IEnumerable<int> monstersList =
                from selectedMonster in Monsters
                where selectedMonster.Type == CreatureType.Monster
                select selectedMonster.ID;
            return monstersList;
        }

        public static IEnumerable<int> MonstersByLocID(int id)
        {
            IEnumerable<int> monstersList =
                from selectedMonster in CreatureLocations
                where selectedMonster.Location== id
                select selectedMonster.CreatureID;
            return monstersList;
        }

        public static IEnumerable<int> StolenItems()
        {
            IEnumerable<int> stolenList =
                from selectedItems in Items
                where selectedItems.ID>=100 && selectedItems.ID < 200
                select selectedItems.ID;
            return stolenList;
        }

        public static IEnumerable<int> LocationListMonster(int monsterID)
        {
            IEnumerable<int> locList =
                from monsterLoc in CreatureLocations
                where monsterLoc.CreatureID == monsterID
                select monsterLoc.Location;
            return locList;
        }

        public static int HitTarget(int dex)
        {
            switch (dex)
            {
                case 1: return 50;
                case 2: return 54;
                case 3: return 56;
                case 4: return 58;
                case 5: return 60;
                case 6: return 62;
                case 7: return 64;
                case 8: return 66;
                case 9: return 68;
                case 10: return 70;
                case 11: return 72;
                case 12: return 74;
                case 13: return 76;
                case 14: return 78;
                case 15: return 80;
                case 16: return 82;
                case 17: return 84;
                case 18: return 86;
                case 19: return 88;
                case 20: return 90;
            }

            return 0;
        }

        public static int AvoidHit(int dex)
        {
            switch (dex)
            {
                case 1: return 10;
                case 2: return 11;
                case 3: return 12;
                case 4: return 13;
                case 5: return 14;
                case 6: return 15;
                case 7: return 16;
                case 8: return 17;
                case 9: return 18;
                case 10: return 19;
                case 11: return 20;
                case 12: return 21;
                case 13: return 22;
                case 14: return 23;
                case 15: return 24;
                case 16: return 25;
                case 17: return 26;
                case 18: return 27;
                case 19: return 28;
                case 20: return 30;
            }

            return 0;
        }

        public static int PriceReduction(int chari)
        {
            switch (chari)
            {
                case 1: return 0;
                case 2: return 0;
                case 3: return 0;
                case 4: return 0;
                case 5: return 5;
                case 6: return 5;
                case 7: return 5;
                case 8: return 5;
                case 9: return 5;
                case 10: return 5;
                case 11: return 8;
                case 12: return 8;
                case 13: return 8;
                case 14: return 8;
                case 15: return 8;
                case 16: return 10;
                case 17: return 10;
                case 18: return 10;
                case 19: return 10;
                case 20: return 10;
            }

            return 0;
        }

        public static int BonusQuest(int chari)
        {
            switch (chari)
            {
                case 1: return 0;
                case 2: return 0;
                case 3: return 0;
                case 4: return 0;
                case 5: return 5;
                case 6: return 5;
                case 7: return 5;
                case 8: return 10;
                case 9: return 10;
                case 10: return 10;
                case 11: return 10;
                case 12: return 15;
                case 13: return 15;
                case 14: return 15;
                case 15: return 20;
                case 16: return 20;
                case 17: return 20;
                case 18: return 20;
                case 19: return 25;
                case 20: return 25;
            }

            return 0;
        }

        public static int SpecialAction(int inte)
        {
            switch (inte)
            {
                case 1: return 30;
                case 2: return 30;
                case 3: return 30;
                case 4: return 30;
                case 5: return 35;
                case 6: return 35;
                case 7: return 35;
                case 8: return 35;
                case 9: return 35;
                case 10: return 50;
                case 11: return 50;
                case 12: return 50;
                case 13: return 65;
                case 14: return 65;
                case 15: return 65;
                case 16: return 65;
                case 17: return 65;
                case 18: return 80;
                case 19: return 80;
                case 20: return 80;
            }

            return 0;
        }

        public static int Damage(int str, int lvl, int minDmg, int maxDmg)
        {
            double factor1 = Math.Pow((str * (1 + lvl / 100)), 2);           
            return Convert.ToInt32(rnd.Next(minDmg, maxDmg + 1) * (1 + factor1 / 100));

        }

        public static int CreateGold()
        {
            
            int gold = rnd.Next(1, 5 + 1)*1000+ rnd.Next(0, 2) * 500;
            return gold;
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

        public static QuestGiver GiverByID(int id)
        {
            foreach (QuestGiver qgiver in QuestGivers)
            {
                if (qgiver.ID == id)
                {
                    return qgiver;
                }
            }

            return null;
        }

        public static QuestWho WhoByID(int id)
        {
            foreach (QuestWho qwho in QuestWhois)
            {
                if (qwho.ID == id)
                {
                    return qwho;
                }
            }

            return null;
        }

        public static WorldLocation LocationByID(int id)
        {
            foreach (WorldLocation location in WorldLocations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }

    }
}
