using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO.Pipelines;
using System.Runtime.InteropServices;

namespace Daniel
{
    class ListaAleatoria
    {
        Random random = new Random();
        List<int> ints = new List<int>();

        void Main()
        {
            for(int i = 0; i < 100; i++)
            {
                int temp = random.Next(1001);
                ints.Add(temp);
            }

            ints.Sort();

            for(int i = 0; i < 100; i++)
            {
                Console.Write(ints[i] + " ");
            }
        }
    }
}