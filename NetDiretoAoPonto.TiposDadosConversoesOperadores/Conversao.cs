/* using System;

namespace NetDiretoAoPonto.TiposDadosConversoesOperadores
{
    class Conversao
    {

        static void Main(string[] args)
        {

        #region Conversões

        int notaAlumo = 10;

        // Conversão implícita 
        double notaAlunoDouble = notaAluno;

        // Conersão Explícita 
        int numeroDoubleComoInt = (int)notaAlunoDouble;

        // Conersão utilizando Convert 
        string notaString = "10";

        int notaConvert = Convert.ToInt32(notaString);

        // Conversão utilizando Parse 

        int notaPare = int.Parse(notaString);

        if (int.TryParse(notaString, out int notaTryParse))
            {
                
            } else {
              Console.WriteLine("Número em formato inválido.");
            }

        #endregion


        }


    }
} */
