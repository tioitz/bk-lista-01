namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor em fahrenheit: ");
            double fahrenheit = Double.Parse(Console.ReadLine());

            double celsius;
            celsius = (fahrenheit - 32) / 1.8;

            Console.WriteLine("A temperatura em celsius é {0}", celsius);
        }
    }
}
