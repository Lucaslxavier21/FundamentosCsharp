using System; 

namespace NetDiretoAoPonto.TratandoExcessoes
{
    class Program
    {
        static void Main(string[] argas)
        {
            #region Tratando Excessões
            var seteString = "sete";
            string valorNull = null;
            var longValue = long.MaxValue.ToString();

            try
            {
                var formateException = int.Parse(seteString);
                var argumentException = int.Parse(valorNull);
                var overflowException = int.Parse(longValue);

            } catch (FormatException exception)
            {
                Console.WriteLine($"Format Exception: {exception.Message}");
            } catch(ArgumentNullException exception)
            {
                Console.WriteLine($"Argument Null Exception: {exception.Message}");
            } catch(OverflowException exception)
            {
                Console.WriteLine($"Overflow Exception: {exception.Message}");
            } finally
            {
                Console.WriteLine($"Este código é executado sempre.");
            }




            #endregion

            Console.ReadKey();
        }
    }
}