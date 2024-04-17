using System;

namespace Task_1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------\nПерший випадок \n----------------------------");
            Bud bud1 = new Bud("Зелений", false);
            Petal[] petals1 = { new Petal("Жовтий"), new Petal("Помаранчевий"), new Petal("Червоний") };
           
            Console.WriteLine(bud1.ToString());

            Flower flower1 = new Flower(bud1, petals1);
            flower1.Blossom();

            Console.WriteLine("\n----------------------------\nДругий випадок \n----------------------------");
            Bud bud2 = new Bud("Зелений", true);
            Petal[] petals2 = { new Petal("Жовтий"), new Petal("Помаранчевий"), new Petal("Червоний") };

            Console.WriteLine(bud2.ToString());

            Flower flower2 = new Flower(bud2, petals2);
            flower2.Blossom();

            Console.ReadKey();
        }
    }
}
