using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bst_Example_0
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node (int data)
        {
            this.data = data;
            left = right = null;
        }
        public Node()
        {
            left = right = null;
        }
    }
}
