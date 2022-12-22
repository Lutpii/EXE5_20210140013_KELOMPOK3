using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_20210140013_KELOMPOK3
{
    class Node
    {
        public string name;
        public Node next;
    }

    class queue
    {
        Node adi, roki;
        public queue()
        {
            adi = null;
            roki = null;
        }

        public void insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element: ");
            nm = Console.ReadLine();
            newnode.name = nm;
            newnode.next = null;
            if (adi == null)
            {
                adi = newnode;
                roki = newnode;
                return;
            }
            roki.next = newnode;
            roki = newnode;
        }

        public void delete()
        {
            if (adi == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            adi = adi.next;
            if (adi == null)
                roki = null;
        }

        public void display()
        {
            if (adi == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            Node display;
            for (display = adi; display != null; display = display.next)
                Console.WriteLine(display.name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            queue q = new queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            q.insert();
                            break;
                        case '2':
                            q.delete();
                            break;
                        case '3':
                            q.display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}
