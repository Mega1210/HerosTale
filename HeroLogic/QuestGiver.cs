using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HeroLogic.World;

namespace HeroLogic
{
    public class QuestGiver
    {
        public int ID { get; set; }        
        public string NameGiver { get; set; }
        public string Pronoun { get; set; }

        public QuestGiver (int id, string nameGiver, string pronoun)
        {
            ID = id;           
            NameGiver = nameGiver;
            Pronoun = pronoun;
        }
    }
}
