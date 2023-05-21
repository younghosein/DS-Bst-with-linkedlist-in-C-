using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bst_Example_0
{
    class Bst
    {
        public Node root;
        public Bst()
        {
            root = null;
        }
        public Node search(Node root, int d)
        {
            if (root == null || root.data == d)
            {
                return root;
            }

            if (root.data < d)
            {
                return search(root.right, d);
            }

            return search(root.left, d);
        }
        public Node insert(Node r, int nd)
        {
            if (r == null)
            {
                r = new Node(nd);
                return r;
            }

            if (nd < r.data)
            {
                r.left = insert(r.left, nd);
            }
            else if (nd > r.data)
            {
                r.right = insert(r.right, nd);
            }

            return r;
        }
        public void inOrder(Node r)
        {
            if (r != null)
            {
                inOrder(r.left);
                Console.Write(r.data + " . ");
                inOrder(r.right);
            }
        }
        public void preOrder(Node r)
        {
            if (r == null)
            {
                return;
            }
            Console.Write($"{r.data} . ");
            preOrder(r.left);
            preOrder(r.right);
        }
        public void postOrder(Node r)
        {
            if (r == null)
            {
                return;
            }
            postOrder(r.left);
            postOrder(r.right);
            Console.Write($"{r.data} . ");
        }
        public int count(Node r)
        {
            if (r == null)
            {
                return 0;
            }
            int c = (1 + (count(r.left) + (count(r.right))));
            return c;
        }
        public void levelOrder(Node r, int l)
        {
            if (r == null)
            {
                return;
            }
            if (l == 1)
            {
                Console.Write(r.data + " . ");
            }
            else if (l > 1)
            {
                levelOrder(r.left, l - 1);
                levelOrder(r.right, l - 1);
            }
        }
        public int minValue(Node r)
        {
            int mv = r.data;
            while (r.left != null)
            {
                mv = r.left.data;
                r = r.left;
            }
            return mv;
        }
        public Node delete(Node r, int dd)
        {
            if (r == null)
            {
                Console.WriteLine("The Bst Is Empty !");
                return r;
            }

            if (dd < r.data)
            {
                r.left = delete(r.left, dd);
            }
            else if (dd > r.data)
            {
                r.right = delete(r.right, dd);
            }

            else
            {
                if (r.left == null)
                {
                    return r.right;
                }
                else if (r.right == null)
                {
                    return r.left;
                }

                r.data = minValue(r.right);

                r.right = delete(r.right, r.data);
            }
            return r;
        }
        public int min(Node r)
        {
            while (r.left != null)
            {
                r = r.left;
            }
            return r.data;
        }
        public int max(Node r)
        {
            while (r.right != null)
            {
                r = r.right;
            }
            return r.data;
        }
        public void oddLevel(Node r, bool isOdd)
        {
            if (r == null)
            {
                return;
            }

            if (isOdd == true)
            {
                Console.Write(r.data + " . ");
            }

            oddLevel(r.left, !isOdd);
            oddLevel(r.right, !isOdd);
        }
        public void fullNode(Node r)
        {
            if (r != null)
            {
                fullNode(r.left);
                if (r.left != null && r.right != null)
                {
                    Console.Write(r.data + " . ");
                }
                fullNode(r.right);
            }
        }
        public void levelNode(Node r, int l, int h)
        {
            LinkedList<Node> Q = new LinkedList<Node>();

            Node m = new Node();

            int lvl = 1;

            Q.AddLast(r);
            Q.AddLast(m);

            while (Q.Count > 0)
            {
                Node n = Q.First.Value;
                Q.RemoveFirst();

                if (n == m)
                {
                    Console.WriteLine("");
                    lvl++;

                    if (Q.Count == 0 || lvl > h)
                    {
                        break;
                    }

                    Q.AddLast(m);

                    continue;
                }

                if (lvl >= l)
                {
                    Console.Write(n.data + " . ");
                }

                if (n.left != null)
                {
                    Q.AddLast(n.left);
                }

                if (n.right != null)
                {
                    Q.AddLast(n.right);
                }
            }
        }
        public int SumAll(Node r)
        {
            if (r == null)
            {
                return 0;
            }
            //else
            int s = 0;
            s = (r.data + SumAll(r.left) + SumAll(r.right));
            return s;
        }
    }
}
