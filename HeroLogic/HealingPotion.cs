using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HeroLogic.World;

namespace HeroLogic
{
    public class HealingPotion:Item
    {
        
        public int AmountToHeal { get; set; }

        public HealingPotion(int id, string name, string namePlural, int amountToHeal,int plusStr, int plusDex, int plusInt, int plusChar,
             int plusGold, int plusExp, ItemRarity rarity, ItemType type, int baseValue) : base(id, name, namePlural, plusStr, plusDex, plusInt, plusChar,
            plusGold, plusExp, rarity, type, baseValue)
        {
            AmountToHeal = amountToHeal;
        }
    }
}
