namespace Exercício14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite o ultimo valor da sequencia");

            numero = 0;

            Console.WriteLine("0");
            Console.WriteLine("1");
            int numAnterior = 0, numAtual = 1, proxNumero;
            for (int i = 1; i < numero; i++)
            {
                proxNumero = numAnterior + numAtual;
                if ( proxNumero <= numero)
                {
                    Console.WriteLine(proxNumero);
                    numAnterior = numAtual;
                    numAtual = proxNumero;
                }
            }
        }
    }
}
