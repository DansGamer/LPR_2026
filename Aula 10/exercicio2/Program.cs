using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO.Pipelines;
using System.Runtime.InteropServices;

namespace Daniel
{
    public class Funcionario
    {
        double SalarioBruto, SalarioLiquido;
        string Nome;
        double Imposto;

        public Funcionario(string n, double s)
        {
            Nome = n;
            SalarioBruto = s;
            DescontoImposto();
        }

        public void DescontoImposto()
        {
            if(SalarioBruto <= 2000)
            {
                Imposto = 0.1;
            }
            else if(SalarioBruto > 3000)
            {
                Imposto = 0.2;
            }
            else
            {
                Imposto = 0.15;
            }

            SalarioLiquido = SalarioBruto - SalarioBruto * Imposto;
        }

        public void Aumento(double i)
        {
            SalarioBruto += SalarioBruto * i;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"O funcionário {Nome} ganha R${SalarioLiquido:F2} de salário líquido");
        }
    }
}