using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace construtores_finalizadores
{
    class Program
    {

        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Thaynara", "thaynara.brito@estudante.iftm.edu.br", "991585039");

            Console.WriteLine(p.Nome);

            Console.ReadKey();
        }
    }
}

