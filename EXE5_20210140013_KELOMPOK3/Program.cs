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
        
        }
    }
}
