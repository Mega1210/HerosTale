using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HeroLogic.World;

namespace HeroLogic
{
    public class PlayerQuest
    {
        public QuestOption ID { get; set; }
        public bool IsCompleted { get; set; }

        public PlayerQuest(QuestOption id)
        {
            ID = id;
            IsCompleted = false;
        }
    }
}
