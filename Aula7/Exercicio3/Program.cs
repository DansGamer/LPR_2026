using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO.Pipelines;
using System.Runtime.InteropServices;

namespace Daniel
{
    class AcheNumeroArray
    {
        static int[] numbers = new int[10];
        static int search;

        static void Main()
        {
            Console.WriteLine("Escreva 10 numeros inteiro a seguir!\n");
            for(int i = 0; i < numbers.Length; i++) 
            {
                Console.Write($"Numero {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nAgora, digite um numero inteiro que voce deseja encontrar no vetor!");
            Console.Write("Numero procurado: ");
            search = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            int index = 0; int qnt = 0;
            while(Array.IndexOf(numbers, search, index) != -1)
            {
                index = Array.IndexOf(numbers, search, index);
                Console.WriteLine($"Uma instancia desse numero foi achada no index: {index}");
                index++; qnt++;
            }
            Console.WriteLine($"Há {qnt} instancias desse valor no vetor!");
        }
        
    }
}