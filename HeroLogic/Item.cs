using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HeroLogic.World;

namespace HeroLogic
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public int MinDmg { get; set; }
        public int MaxDmg { get; set; }
        public int AmountHP { get; set; }
        public int PlusStr { get; set; }
        public int PlusDex { get; set; }
        public int PlusInt { get; set; }        
        public int PlusChar { get; set; }
        public int PlusGold { get; set; }
        public int PlusExp { get; set; }
        public ItemRarity Rarity { get; set; }
        public ItemType Type { get; set; }
        public int BaseValue { get; set; }

        public Item(int id, string name, string namePlural, int minDmg, int maxDmg, int amountHP, int plusStr, int plusDex, int plusInt, int plusChar, int plusGold, int plusExp, ItemRarity rarity, 
            ItemType type, int baseValue)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
            MinDmg= minDmg;
            MaxDmg = maxDmg;
            AmountHP= amountHP;
            PlusStr = plusStr;
            PlusInt = PlusInt;
            PlusDex = plusDex;
            PlusChar = plusChar;
            PlusGold = plusGold;
            PlusExp = plusExp;
            Rarity = rarity;
            Type = type;
            BaseValue = baseValue;

        }
    }
}
