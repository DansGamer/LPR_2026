using System;

namespace Daniel
{
    class Funcionario
    {
        static void Main()
        {
            Console.WriteLine("Insira seu ID de funcionario:");
            string ID = Console.ReadLine();
            Console.WriteLine("Insira o valor de horas trabalhadas:");
            float WorkHours = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Insira seu pagamento por hora:");
            float PayPerHour = Convert.ToSingle(Console.ReadLine());

            float Paycheck = WorkHours * PayPerHour;

            Console.WriteLine("");
            Console.WriteLine($"Ola funcionario {ID}, seu pagamento por hora e de U${PayPerHour} e você trabalhou {WorkHours} horas!");
            Console.WriteLine($"Ou seja, voce recebera U${Paycheck:F2}!");
        }
    }
}