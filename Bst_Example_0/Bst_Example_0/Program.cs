using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bst_Example_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Bst b = new Bst();
            b.root = new Node(25);

            b.insert(b.root, 15);
            b.insert(b.root, 30);
            b.insert(b.root, 9);
            b.insert(b.root, 18);
            b.insert(b.root, 27);
            b.insert(b.root, 35);
            b.insert(b.root, 12);
            b.insert(b.root, 17);
            b.insert(b.root, 26);
            b.insert(b.root, 29);
            /*
                   25
                /      \
               15       30
              /  \     /  \
            9    18   27   35 

            */
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Binary Search Tree With Inorder Traversal Is : ");
            b.inOrder(b.root);
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Binary Search Tree With Preorder Traversal Is : ");
            b.preOrder(b.root);
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Binary Search Tree With Postorder Traversal Is : ");
            b.postOrder(b.root);
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("The Count Of Binary Search Tree Is : ");
            int c = b.count(b.root);
            Console.Write(c);
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Binary Search Tree With Levelorder Traversal Is : ");
            int l = b.count(b.root);
            int i;
            for (i = 1; i <= l; i++)
            {
                b.levelOrder(b.root, i);
            }
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Please Enter A Number In BST To Be Delete : ");
            int k = int.Parse(Console.ReadLine());
            b.delete(b.root, k);
            Console.WriteLine($"\n{k} Is Deleted...");
            int ld = b.count(b.root);
            Console.WriteLine($"\nNow The Count Of BST Is : {ld}");
            int id;
            Console.WriteLine("\nNow Binary Search Tree With Levelorder Traversal Is : ");
            for (id = 1; id <= ld; id++)
            {
                b.levelOrder(b.root, id);
            }
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("The Minimum Of Binary Search Tree Is : ");
            int mn = b.min(b.root);
            Console.Write(mn);
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("The Maximum Of Binary Search Tree Is : ");
            int mx = b.max(b.root);
            Console.Write(mx);
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Binary Search Tree With Odd Level Traversal Is : ");
            b.oddLevel(b.root, true);
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Binary Search Tree's Full Node Is : ");
            b.fullNode(b.root);
            Console.WriteLine("\n");

            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("Enter Low Level : ");
            //int low = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter High Level : ");
            //int high = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nNodes Between Two Given Level Numbers Is : ");
            //b.levelNode(b.root, low, high);
            //Console.WriteLine("\n");

            int s=b.SumAll(b.root);
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
