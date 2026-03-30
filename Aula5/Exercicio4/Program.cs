using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Daniel
{
    class SomaDigitosQuadrado
    {
        static void Main()
        {
            string Num = "";
            int soma = 0;
            bool Valid = false;
            while(!Valid)
            {
                Console.WriteLine("Insira o numero que você quer descobir a soma dos digitos de seu quadrado:");
                Num = Console.ReadLine();
                if(int.TryParse(Num, out _))
                {
                    Valid = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Numero Invalido, tente novamente!");
                    Console.WriteLine("");
                }
            }

            int Num2 = Convert.ToInt32(Num) * Convert.ToInt32(Num);
            //int n = Convert.ToString(Num2).Length;
            //Console.WriteLine(n);
            Console.WriteLine(Num2);
            while(Num2 > 0)
            {
                int a = Num2 % 10;
                Num2 = Num2/10;
                soma += a;
            }
            
            Console.WriteLine($"A soma dos digitos do quadrado desse numero e igual a {soma}");
        }
    }
}