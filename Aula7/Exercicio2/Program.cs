using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Daniel
{
    class SelecaoHerois
    {
        int[] numbers = new int[10];

        void main()
        {
            Console.WriteLine("Escreva 10 numeros inteiro a seguir!");
            for(int i = 0; i < numbers.Length; i++) 
            {
                Console.Write($"\nNumero {i + 1}: ");
                numbers[i] = Console.ReadLine();
            }
        }
        
    }
}