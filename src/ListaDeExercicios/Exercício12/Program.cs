namespace Exercício12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para calcular o seu fatorial: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            int resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }

            Console.WriteLine($"O fatorial do número {numero} é {resultado}");
        }
    }
}
