using System;

namespace Daniel
{
    class HelloWorld
    {
        static void Main()
        {
            Console.WriteLine("Insira o ID do item 1:");
            string ID1 = Console.ReadLine();
            Console.WriteLine("Insira a quantidade do item 1:");
            int Quantity1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o preco do produto 1:");
            float Price1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Insira o ID do item 2:");
            string ID2 = Console.ReadLine();
            Console.WriteLine("Insira a quantidade do item 2:");
            int Quantity2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o preco do produto 2:");
            float Price2 = Convert.ToSingle(Console.ReadLine());

            float FullPay = Quantity1 * Price1 + Quantity2 * Price2;

            Console.WriteLine("");
            Console.WriteLine($"O valor total da compra e de R${FullPay:F2}!");
            Console.WriteLine($"O produto de ID {ID1}, foi comprado em {Quantity1} unidades e o preco unitario e de R${Price1:F2}!");
            Console.WriteLine($"O produto de ID {ID2}, foi comprado em {Quantity2} unidades e o preco unitario e de R${Price2:F2}!");
        }
    }
}