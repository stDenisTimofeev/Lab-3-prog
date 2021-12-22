using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_prog
{
    public interface IModel
    {
        event Action Changed;
        IEnumerable<Node> AllNodes { get; }
        void AddNode(int value);
        void RemoveLastNode();
        int Count { get; }
        public void ChangeColorWithX(int x);
    }
}
