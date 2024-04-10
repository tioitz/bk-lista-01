namespace Exercício10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            bool par = false;
            bool impar = false;

            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            par = numero % 2 == 0;
            impar = numero % 2 == 1;

            if (par)
            {
                Console.WriteLine("O número é par");
                return;
            }
            if (impar)
            {
                Console.WriteLine("O número é impar");
                return;
            }
        }
    }
}
