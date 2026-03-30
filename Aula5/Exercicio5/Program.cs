using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Daniel
{
    class TreinamentoJedi
    {
        static void Main()
        {
            float Days = 0, Weeks = 0, Months = 0;
            bool Valid = false;
            while(!Valid)
            {
                Console.WriteLine("Insira o numero de horas que voce treinara por dia para se tornar um Jedi:");
                string horas = Console.ReadLine();
                if(double.TryParse(horas, out _))
                {
                    Valid = true;
                    double perDay = Convert.ToDouble(horas);
                    Days = (float)1000/(float)perDay;
                    Weeks = (float)Days/(float)7;
                    Months = (float)Weeks/(float)4.5;
                    Console.WriteLine($"Dias: {Days}");
                    Console.WriteLine($"Semanas: {Weeks}");
                    Console.WriteLine($"Meses: {Months}");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Insira um numero valido!");
                }
            }

            Console.WriteLine($"Você precisaria gastar {Days:F2} dias treinando para se tornar um Jedi, ou {Weeks:F2} semanas, ou {Months:F2} meses!");
        }   
    }
}