using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO.Pipelines;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Daniel
{
    class MultiplicacaoMatrizes
    {
        static int[,] matrizA = new int[3,3];
        static int[,] matrizB = new int[3,3];
        static int[,] matrizC = new int[3,3];
        static void Main()
        {
            Console.WriteLine("Bem vindo, prepare-se para digitar as matrizes que voce quer multiplicar!");
            Console.WriteLine("(Aperte Enter para iniciar)");
            Console.ReadLine();

            GetValues();
            MakeValues();
            ShowValues();
        }

        static void GetValues()
        {
            Console.WriteLine("Matriz A: \n| a b c |\n| d e f |\n| g h i |");

            Console.WriteLine("\nInsira os respectivos valores:");
            Console.Write("a = "); matrizA[0, 0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = "); matrizA[0, 1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = "); matrizA[0, 2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("d = "); matrizA[1, 0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("e = "); matrizA[1, 1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("f = "); matrizA[1, 2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("g = "); matrizA[2, 0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("h = "); matrizA[2, 1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("i = "); matrizA[2, 2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAperte Enter para continuar!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Matriz B: \n| j k l |\n| m n o |\n| p q r |");

            Console.WriteLine("\nInsira os respectivos valores:");
            Console.Write("j = "); matrizB[0, 0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("k = "); matrizB[0, 1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("l = "); matrizB[0, 2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = "); matrizB[1, 0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("n = "); matrizB[1, 1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("o = "); matrizB[1, 2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("p = "); matrizB[2, 0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("q = "); matrizB[2, 1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("r = "); matrizB[2, 2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAperte Enter para continuar!");
            Console.ReadLine();
            Console.Clear();
        }

        static void MakeValues()
        {
            matrizC[0,0] = matrizA[0,0] * matrizB[0,0] + matrizA[0,1] * matrizB[1,0] + matrizA[0,2] * matrizB[2,0];
            matrizC[0,1] = matrizA[0,0] * matrizB[0,1] + matrizA[0,1] * matrizB[1,1] + matrizA[0,2] * matrizB[2,1];
            matrizC[0,2] = matrizA[0,0] * matrizB[0,2] + matrizA[0,1] * matrizB[1,2] + matrizA[0,2] * matrizB[2,2];
            matrizC[1,0] = matrizA[1,0] * matrizB[0,0] + matrizA[1,1] * matrizB[1,0] + matrizA[1,2] * matrizB[2,0];
            matrizC[1,1] = matrizA[1,0] * matrizB[0,1] + matrizA[1,1] * matrizB[1,1] + matrizA[1,2] * matrizB[2,1];
            matrizC[1,2] = matrizA[1,0] * matrizB[0,2] + matrizA[1,1] * matrizB[1,2] + matrizA[1,2] * matrizB[2,2];
            matrizC[2,0] = matrizA[2,0] * matrizB[0,0] + matrizA[2,1] * matrizB[1,0] + matrizA[2,2] * matrizB[2,0];
            matrizC[2,1] = matrizA[2,0] * matrizB[0,1] + matrizA[2,1] * matrizB[1,1] + matrizA[2,2] * matrizB[2,1];
            matrizC[2,2] = matrizA[2,0] * matrizB[0,2] + matrizA[2,1] * matrizB[1,2] + matrizA[2,2] * matrizB[2,2];
        }

        static void ShowValues()
        {
            Console.WriteLine("\nO resultado da multiplicação entre as matrizes A e B é:\n");
            Console.WriteLine($"Matriz A*B: \n| {matrizC[0,0]} {matrizC[0,1]} {matrizC[0,2]} |\n| {matrizC[1,0]} {matrizC[1,1]} {matrizC[1,2]} |\n| {matrizC[2,0]} {matrizC[2,1]} {matrizC[2,2]} |");
        }
    }
}