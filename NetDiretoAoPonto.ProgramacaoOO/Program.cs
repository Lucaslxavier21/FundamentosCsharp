using System; 

namespace NetDiretoAoPonto.ProgramacaoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var professor = new Professor(5000m, "João", "12345", new DateTime(1980, 1, 1));
            var estudante = new Estudante("A", "Lucas", "54321", new DateTime(2000, 5, 5));

            var pessoas = new List<Pessoa> { estudante, professor };

            foreach(var pessoa in pessoas)
            {
                pessoa.SeApresentar();
            }

            Console.ReadKey();
        }
    }
}
