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

    public class Load
    {
        void Main()
        {
            double SalarioConvertido = 0;
            Console.WriteLine("Insira os dados do funcionário na seguinte ordem:");
            Console.WriteLine("Nome e Salário Bruto");
            string Nome = Console.ReadLine();
            string SalarioString = Console.ReadLine();

            if(double.TryParse(SalarioString, out SalarioConvertido))
            {
                double AumentoConvertido = 0;
                Funcionario empregado = new Funcionario(Nome, SalarioConvertido);
                Console.WriteLine("Cadastrado!");
                Console.WriteLine("Exibindo informações...");
                empregado.PrintInfo();
                Console.WriteLine("Insira um valor de aumento para esse funcionário:");
                string AumentoString = Console.ReadLine();

                if(double.TryParse(AumentoString, out AumentoConvertido))
                {
                    empregado.Aumento(AumentoConvertido);
                    Console.WriteLine("Aumento processado!");
                }
                else
                    Console.WriteLine("O Aumento não pode ser convertido em número...");
                Console.WriteLine("Exibindo informações...");
                empregado.PrintInfo();
            }
            else
                Console.WriteLine("O salário não pode ser convertido em número... Reinicie e tente novamente");

            Console.WriteLine("Encerrando programa, obrigado por nos escolher!");
        }
    }
}