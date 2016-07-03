using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroLogic
{
    public class WorldLocation
    {
        public int ID { get; set; }
        public string LocationName { get; set; }
        
        public WorldLocation(int id, string locationName)
        {
            ID = id;
            LocationName = locationName;
        }
    }
}
