using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHeranca02
{
    internal class Aluno : Pessoa
    {
        string RegistroAluno;
        DateTime DataMatricula;

        public Aluno(string nome, DateTime dtnasc, string cpf, string registroaluno, DateTime datamatricula) : base (nome, dtnasc, cpf)
        {
            RegistroAluno = registroaluno;
            DataMatricula = datamatricula;
        }

        public override string ToString()
        {
            return base.ToString() + "Registro do Aluno: " + RegistroAluno + "\nData de Matricula: " + DataMatricula.ToLongDateString();
        }
    }
}
