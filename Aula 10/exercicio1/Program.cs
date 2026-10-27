using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Daniel
{
    public class Retangulo
    {
        double Altura;
        double Largura;

        public Retangulo(double a, double l)
        {
            Altura = a;
            Largura = l;
        }

        public void CalcArea()
        {
            double Area = Largura * Altura;
            Console.WriteLine($"A área desse retângulo é de {Area}m²");
        }

        public void CalcPerimetro()
        {
            double Perim = Largura * 2 + Altura * 2;
            Console.WriteLine($"O perímetro desse retângulo é de {Perim}m");
        }
    }

    public class Load()
    {
        static void Main()
        {
            double Altura = 0;
            Console.WriteLine("Insira os dados do retângulo, em metros, na seguinte ordem:");
            Console.WriteLine("Altura e Largura");
            Console.WriteLine("Insira a altura:");
            string AlturaString = Console.ReadLine();

            if(double.TryParse(AlturaString, out Altura))
            {
                double Largura = 0;
                Console.WriteLine("Altura Cadastrado!");
                Console.WriteLine("Insira a largura:");
                string LarguraString = Console.ReadLine();

                if(double.TryParse(LarguraString, out Largura))
                {
                    Console.WriteLine("Largura processada!");
                    Console.WriteLine("Exibindo informações...");
                    Retangulo ret = new Retangulo(Altura, Largura);
                    ret.CalcArea();
                    ret.CalcPerimetro();
                }
                else
                    Console.WriteLine("A Largura não pode ser convertido em número...");
            }
            else
                Console.WriteLine("A altura não pode ser convertido em número... Reinicie e tente novamente");

            Console.WriteLine("Encerrando programa, obrigado por nos escolher!");
        }
    }
}