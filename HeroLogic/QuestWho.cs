﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroLogic
{
    public class QuestWho
    {
        public int ID { get; set; }
        public string NameWho { get; set; }
        public string Pronoun { get; set; }

        public QuestWho(int id, string nameWho, string pronoun)
        {
            ID = id;
            NameWho = nameWho;
            Pronoun = pronoun;
        }
    }
}
