using System;

namespace NetDiretoAoPonto.EstruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESTRUTURA DE REPETIÇÃO FOR 

             Console.WriteLine("Digite uma sequeência de números separados por espaço.");
            // 0 1 2 3 4 5 6 7 8 9 10

            var numerosText = Console.ReadLine();

            var numeros = numerosText.Split(' ');

            Console.WriteLine("Usando For: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            
            } 

            // ESTRUTURA DE REPETIÇÃO WHILE 

            Console.WriteLine("Utilizando While: ");

            var contador = 0;

            while (contador < numeros.Length)
            {
                Console.WriteLine(numeros[contador]);

                contador++;
            }

            // ESTRUTURA DE REPETIÇÃO FOREACH 

            Console.WriteLine("Utilizando o ForEach: ");

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();


        }
    }
}