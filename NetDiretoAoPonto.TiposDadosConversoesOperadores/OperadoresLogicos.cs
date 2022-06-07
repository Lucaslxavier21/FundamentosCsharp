using System;

namespace CsharpDiretoAoPontoHelloWorld
{
     class OperadoresLogicos
    {
        static void Main(string[] args)
        {
            #region Operadores Lógicos = AND( && ) e OR ( || )
            
            // EXEMPLO;

            var minhaNota = 4;
            var ultimoAno = true;

            if (minhaNota >= 7 && ultimoAno)
            {
                Console.WriteLine("Aprovado com sucesso");
            } 

            if (minhaNota >= 7 || ultimoAno)
            {
                Console.WriteLine("Aprovado");
            } 

            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);

            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);


            #endregion

            Console.ReadLine();

        }
    }
}
