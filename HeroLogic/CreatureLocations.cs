using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HeroLogic.World;

namespace HeroLogic
{
    public class CreatureLocations
    {
        public int EntryID { get; set; }
        public int Location { get; set; }        
        public int CreatureID { get; set; } 
        
        public CreatureLocations(int entryID, int location, int creatureID)
        {
            EntryID = entryID;
            Location = location;            
            CreatureID = creatureID;
        }
    }
}
