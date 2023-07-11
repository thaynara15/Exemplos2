using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace construtores_finalizadores
{
    class Pessoa
    {

        private string nome;
        private string email;
        private string telefone;

        private Endereco endereco;

        public Pessoa(string nome = "", string email = "", string telefone = "")
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;

            this.endereco = new Endereco();
        }

        ~Pessoa()
        {
            Console.WriteLine("Olá, mundo!");
        }

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}