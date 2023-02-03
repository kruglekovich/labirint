using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labirint
{
    enum Direction
    {
        North, East, South, West
    }
    abstract class MapSide
    {
        public abstract void Enter();
    }
}
