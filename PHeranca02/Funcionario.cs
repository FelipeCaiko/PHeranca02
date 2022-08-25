using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHeranca02
{
    internal class Funcionario : Pessoa
    {
        string NumeroPis;
        double Salario;
        string Setor;

        public Funcionario(string nome, DateTime dtnasc, string cpf, string numeropis, double salario, string setor) : base(nome, dtnasc, cpf)
        {
            NumeroPis = numeropis;
            Salario = salario;
            Setor = setor;
        }

        public override string ToString()
        {
            return base.ToString() + "Número do PIS: " + NumeroPis + "\nSalario: " + Salario + "\nSetor: " + Setor;
        }
    }
}
