using System;
namespace PHeranca02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cadastro aluno
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            DateTime datanasc = DateTime.Parse(Console.ReadLine());

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Registro do Aluno: ");
            string registroaluno = Console.ReadLine();

            Console.Write("Data de Matricula: ");
            DateTime datamatricula = DateTime.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(nome, datanasc, cpf, registroaluno, datamatricula);

            Console.Clear();

            Console.WriteLine(aluno.ToString());

            Console.ReadKey();

            //Cadastro funcionario

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            datanasc = DateTime.Parse(Console.ReadLine());

            Console.Write("CPF: ");
            cpf = Console.ReadLine();

            Console.Write("Numero do PIS: ");
            string numeropis = Console.ReadLine();

            Console.Write("Salario: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Setor: ");
            string setor = Console.ReadLine();

            Funcionario funcionario = new Funcionario(nome, datanasc, cpf, numeropis, salario, setor);

            Console.Clear();

            Console.WriteLine(funcionario.ToString());

            Console.ReadKey();



        }
    }
}