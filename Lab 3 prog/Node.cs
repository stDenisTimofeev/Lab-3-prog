using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_3_prog
{
    public class Node
    {
        int value;
        int x, y;
        public Node(int value, int x, int y)
        {
            this.x = x;
            this.y = y;
            ColorPen = Pens.Red;
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }

        }
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }

        }
        public Pen ColorPen { get; set; }
    }
}
