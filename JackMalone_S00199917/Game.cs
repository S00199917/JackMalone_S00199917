﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackMalone_S00199917
{
    class Game
    {
        public string Name { get; set; }
        public int CriticScore { get; set; }
        public decimal Price { get; set; }
        public string GameImage { get; set; }
        public string Description { get; set; }

        public void DecreasePrice(decimal decrease)
        {
            Price -= decrease;
        }
    }
}
