using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndFriendss
{
    class Program
    {
        static void Main(string[] args)
        {

            // DONT FORGET CATCHING USER ERRORS


            // Number 2
            
            Console.WriteLine("How many integers should be put into an stack and then printed out reversed?");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Random rnd = new Random();
            int i = 0;
            Stack<int> numbers = new Stack<int>();
            while (i != A)
            {
                int number = rnd.Next(10);
                numbers.Push(number);
                Console.WriteLine(number);
                i++;
            }
            Console.ReadLine();
            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }
            Console.ReadLine();

            // Number 7
            const int SIZE = 9;
            int[] NUMBERS = new int[SIZE] { 1, 1, 1, 2, 1, 1, 2, 1, 1 };
            int[] COUNT = new int[10];
            Console.WriteLine("The array is {1, 1, 1, 2, 1, 1, 2, 1, 1}");
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < NUMBERS.Length; y++)
                {
                    if (NUMBERS[y] == x)
                    {
                        COUNT[x]++;
                    }
                }
            }
            for (int x = 0; x < 10; x++)
                Console.WriteLine(x + " appears " + COUNT[x] + " times");

            Console.ReadLine();


            // Number 9
            Console.WriteLine("Input a number (N)");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            var myQueue = new Queue<int>();
            myQueue.Enqueue(N);
            //List<int> numbahs = new List<int>();
            
            for (int j = 0; j < 16; j++)
            {
                myQueue.Enqueue(N + 1);
                myQueue.Enqueue(2 * N + 1);
                myQueue.Enqueue(N + 2);
                //numbahs.Add(N);
                Console.WriteLine(N);
                myQueue.Dequeue();
                N = myQueue.Peek();
            }

            while (myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Peek());
                myQueue.Dequeue();
            }
            

            Console.ReadLine();

            //Console.WriteLine("\nThis is the old one:");
            //foreach (int numbah in myQueue)
            //{
            //    numbahs.Add(numbah);
            //}
            //Console.WriteLine(String.Join(",", numbahs));
            //Console.WriteLine(numbahs.Count());
            //Console.ReadLine();

            // Number Paragraph
            // One situation where I would use a Linked List in the real world would be in a situation where you would have to have
            // memory management in one of your programs. You would use a linked list instead of for example, an array, because arrays
            // can't have its size changed and is a hassle to rearrange the items inside of it. A linked list can have its size changed
            // or what order it comes in very easily due to the ends of each node pointing to another node. An example of this memory
            // management idea would be with search history, as with a doubly linked list you can have each literal link that you click
            // on in a webpage have its own slot and link to other webpages when the user uses the backwards and forwards buttons.
        }
    }
}
