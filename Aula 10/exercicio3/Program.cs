using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO.Pipelines;
using System.Runtime.InteropServices;

namespace Daniel
{
    public class Aluno
    {
        string Matricula, Nome;
        double Prova1, Prova2, Trabalho;
        double Media;
        public Aluno(string n, string s, double p1, double p2, double t)
        {
            Nome = n;
            Matricula = s;
            Prova1 = p1;
            Prova2 = p2;
            Trabalho = t;
        }

        public void MediaCalc()
        {
            Media = (Prova1 * 2.5 + Prova2 * 2.5 + Trabalho * 2)/7;
        }

        public double Final()
        {
            if(Media < 60)
            {
                return (60 - Media);
            }
            else
                return 0;
        }
    }
}