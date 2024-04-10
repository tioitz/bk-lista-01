namespace Exercício11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Digite o valor de a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de b");
            b = Convert.ToInt32(Console.ReadLine());

            var resultado = a + b;

            Console.WriteLine($"O resultado da soma de a + b é {resultado}");
        }
    }
}
