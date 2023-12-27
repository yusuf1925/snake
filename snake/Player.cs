using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public abstract class Player 
    {
        protected int coordinationX { get; set; }
        protected int coordinationY { get; set; }
        protected int locationX { get; set; }
        protected int locationY { get; set; }
        protected int resultX { get; set; }
        protected int resultY { get; set; }


    }
}
