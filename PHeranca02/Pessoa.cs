using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHeranca02
{
    internal class Pessoa
    {
        String Nome;
        DateTime DtNasc;
        String CPF;

        public Pessoa(string nome, DateTime dtnasc, string cpf)
        {
            Nome = nome;
            DtNasc = dtnasc;
            CPF = cpf;
        }

        public void setNome()
        {
            Console.Write("Informe o nome: ");
            this.Nome = Console.ReadLine();
        }

        public void getNome()
        {
            Console.Write("Nome: " + this.Nome);
        }

        public void setDtNasc()
        {
            Console.Write("Informe a data de nascimento: ");
            this.DtNasc = DateTime.Parse(Console.ReadLine());
        }

        public void getDtNasc()
        {
            Console.Write("Data de nascimento: " + this.DtNasc);
        }

        public void setCPF()
        {
            Console.Write("Informe o CPF: ");
            this.Nome = Console.ReadLine();
        }

        public void getCPF()
        {
            Console.Write("CPF: " + this.CPF);
        }

        public override string ToString()
        {
            return "Nome: " + this.Nome + "\n" +
                   "Data de nascimento: " + this.DtNasc.ToLongDateString() + "\n" +
                   "CPF: " + this.CPF + "\n";
        }
    }
}
