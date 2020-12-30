using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1- Inserir novo aluno.");
            Console.WriteLine("2- Listar alunos.");
            Console.WriteLine("3- Calcular média geral.");
            Console.WriteLine("X- Sair.");
            Console.WriteLine();

            string opcaousuario = Console.ReadLine();

            while (opcaousuario.ToUpper() != "X")
            {
                switch (opcaousuario)
                {

                    case "1":
                        //Add aluno
                        break;

                    case "2":
                        //List alunos
                        break;

                    case "3":
                        //Media Geral
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1- Inserir novo aluno.");
                Console.WriteLine("2- Listar alunos.");
                Console.WriteLine("3- Calcular média geral.");
                Console.WriteLine("X- Sair.");
                Console.WriteLine();
                opcaousuario = Console.ReadLine();
            }
        }
    }
}
