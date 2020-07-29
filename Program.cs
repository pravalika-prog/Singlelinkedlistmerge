using System;

namespace Triple
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList list1 = new SingleLinkedList();
            SingleLinkedList list2 = new SingleLinkedList();

            list1.CreateList();
            list2.CreateList();

            list1.BubbleSort();
            list2.BubbleSort();

            Console.WriteLine("First list - "); list1.DisplayList();
            Console.WriteLine("Second List - "); list2.DisplayList();

            SingleLinkedList list3;

            list3 = list1.Merge1(list2);
            Console.WriteLine("Merged List - "); list3.DisplayList();

            Console.WriteLine("First List - "); list1.DisplayList();
            Console.WriteLine("Second List - "); list2.DisplayList();

            list3 = list1.Merge2(list2);
            Console.WriteLine("Merge List - "); list3.DisplayList();

            Console.WriteLine("First List - "); list1.DisplayList();
            Console.WriteLine("Second List - "); list2.DisplayList();
        }
    }
}
