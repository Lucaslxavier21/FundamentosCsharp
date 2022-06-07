using System; 

namespace NetDiretoAoPonto.DebugandoAplicacoes
{
    class Program
    {
        static void Main(string[] argas)
        {
            #region Debugging 
            var numerosString = Console.ReadLine();
            var numeros = numerosString.Split(' '); // Se tiver errdada, você pode testar mudar o valor e avançar com o código 
            
            foreach (var numero in numeros)
            {
                var numeroInt = int.Parse(numero); 

                var aoQuadrado = Math.Pow(numeroInt, 2);

                Console.WriteLine($"{numeroInt} = {aoQuadrado}");
            }


            Console.ReadKey();

            #endregion 
        }
    }
}