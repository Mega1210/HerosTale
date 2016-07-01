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
        public Areas LocationName { get; set; }
        public int CreatureID { get; set; } 
        
        public CreatureLocations(int entryID, Areas locationName, int creatureID)
        {
            EntryID = entryID;
            LocationName = locationName;
            CreatureID = creatureID;
        }
    }
}
