using System;

namespace NetDiretoAoPonto.TrabalhandoComStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var paragrafo = "  C# é uma linguagem modernoa e versátil." +
             "Com C# consigop desenvolver para web, Desktop, Mobile,  Jogos, entre outros.   ";

            // Length
            var tamanho = paragrafo.Length;

            // Empty 
            var vazio = string.Empty;

            // ToLower, ToUpper
            var paragrafoMinuscula = paragrafo.ToLower();
            var paragrafoMaiuscula = paragrafo.ToUpper();

            //Split
            var frases = paragrafo.Split('.');

            //Trim, TrimEnd, TrimStart
            var paragrafoTrim = paragrafo.Trim();
            var paragrafoTrimEnd = paragrafo.TrimEnd();
            var paragrafoTrimStart = paragrafo.TrimStart();

            //IsNullOrWhitespace
            var isNullOrWhitespace = string.IsNullOrWhiteSpace(paragrafo);

            //Replace
            var paragrafoCsharp = paragrafo.Replace("C#", "C-sharp"); */

            #region Buscas com Strings

            var outroParagrafo = "C# é uma linguagem moderna e versátil. " +
                "Com C# consigo desenvolver para web, Desktop, Mobile, Jogos, " +
                "entre outros.";

            // IndexOf
            var indexOf = outroParagrafo.IndexOf("C#");

            // LastIndexOf
            var lastIndexOf = outroParagrafo.LastIndexOf("C#");

            // StartsWith
            var startsWith = outroParagrafo.StartsWith("C#");

            // Substring
            var indexOfMobile = outroParagrafo.IndexOf("Mobile");
            var subStringMobile = outroParagrafo.Substring(indexOfMobile, 6);

            // Contains
            var containsJogos = outroParagrafo.Contains("Jogos", StringComparison.OrdinalIgnoreCase);
            var containsJogosExact = outroParagrafo.Contains("Jogos");
            var containsRuim = outroParagrafo.Contains("ruim");






            #endregion 


            Console.ReadKey();
        }
    }
}
