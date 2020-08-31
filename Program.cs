using System;

namespace oop_6115261004_w07
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Nitat", "Ninchawee", 20000, 10, 2, 2);
            Lecturer l1 = new Lecturer("Nitat", "Ninchawee", 20000, 0, 20, 20, 20, 20, 10);
            SupportPersonnel S1 = new SupportPersonnel("Nitat", "Ninchawee", 20000, 0, 10, 20, 40);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(l1.ToString());
            Console.WriteLine(S1.ToString());
        }
    }
}