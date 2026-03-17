using System;

namespace Daniel
{
    class ParOuImpar
    {
        static void Main()
        {
            int Number = 0;
            bool Valid = false;
            while(!Valid)
            {
                Console.WriteLine("Insira um número:");
                string NumberString = Console.ReadLine();
                if(int.TryParse(NumberString, out _))
                {
                    Valid = true;
                    Number = Convert.ToInt32(NumberString);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("O valor inserido não é um número inteiro válido!");
                }
            }
            
            if(Number % 2 == 0)
            {
                Console.WriteLine($"O número {Number} é par!");
            }
            else
            {
                Console.WriteLine($"O número {Number} é ímpar!");
            }
        }
    }
}
