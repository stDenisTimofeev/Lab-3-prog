using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_3_prog
{
    public class MyModel : IModel
    {
        public event Action Changed;
        LinkedList<Node> nodes = new LinkedList<Node>();
        static Random r = new Random();

        public int Count => nodes.Count;

        public IEnumerable<Node> AllNodes => nodes;

        public void AddNode(int value)
        {
            nodes.AddFirst(new Node(value, r.Next(210), r.Next(270)));
            if (Changed != null) Changed();
        }

        public void RemoveLastNode()
        {
            nodes.RemoveLast();
            if (Changed != null) Changed();
        }

        public void ChangeColorWithX(int x)
        {
            foreach (Node n in nodes)
            {
                if (n.X - 10 <= x && x <= n.X + 10 )
                    n.ColorPen = Pens.Blue;
            }
            if (Changed != null) Changed();
        }

    }
}
