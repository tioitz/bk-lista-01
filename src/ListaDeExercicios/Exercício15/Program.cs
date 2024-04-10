namespace Exercício15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                bool fizz = (i % 3 == 0);
                bool buzz = (i % 5 == 0);
                bool fizzBuzz = fizz && buzz;

                string resultado = fizzBuzz ? "FizzBuzz" : buzz ? "Buzz" : fizz ? "Fizz" : i.ToString();

                Console.WriteLine(resultado);
            }
        }
    }
}
