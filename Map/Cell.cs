﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosStrategy.Map
{
    internal abstract class Cell
    {
        protected Group group { get; set; }
        protected Type type { get; }
        protected Tuple<int, int> coordinates { get; }
        public Cell(Group group, Type type, Tuple<int, int> coordinates)
        {
            this.group = group;
            this.type = type;
            this.coordinates = coordinates;
        }

    }

    enum Group
    {
        Player,
        Enemy,
        Neutral
    }
    enum Type
    {
        Planetary,
        Space,
        Star
    }
}
