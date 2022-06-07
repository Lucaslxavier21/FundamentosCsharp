using System;

namespace NetDiretoAoPonto.EstruturaCondicao
{
    class Program
    {
        static void Main(string[] args)
        {

           /* // Exemplo utilizando IF/ELSE

            Console.WriteLine("Digite o valor da nota:");
            var notaDigitada = Console.ReadLine();

            var nota = int.Parse(notaDigitada);

            if (nota >= 70)
            {
                Console.WriteLine("Aprovado");
            } else if (nota >= 40)
            {
                Console.WriteLine("Em recuperação");
            } else
            {
                Console.WriteLine("Reprovado.");
            } */

            // SWITCH/CASE
            Console.WriteLine("Sejab bem-vindo a empresa X!");

            Console.WriteLine("Digite 1- Contratação de um plano.");
            Console.WriteLine("Digite 2- Recalmação de serviço prestado.");
            Console.WriteLine("Digite 3- Segunda via do boleto.");
            Console.WriteLine("Digite 4- Encerrar atendimento.");

            var opcao = Console.ReadLine();
            
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Informações de um novo plano.");
                    break;
                case "2":
                    Console.WriteLine("Fale sobre sua reclamação.");
                    break;
                case "3":
                    Console.WriteLine("Segunda via do boleto enviada por email.");
                    break;
                case "4":
                    Console.WriteLine("Tenha um bom dia.");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada.");
                    break;
            }

        }
    }
}