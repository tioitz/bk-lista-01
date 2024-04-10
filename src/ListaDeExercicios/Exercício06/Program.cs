namespace Exercício06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double comprimento, largura;

            Console.WriteLine("Qual o comprimento do seu terreno? ");
            comprimento = Double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a largura do seu terreno? ");
            largura = Double.Parse(Console.ReadLine());

            double area = comprimento * largura;

            Console.WriteLine("A área do terreno é de {0}m²", area);

            Console.ReadLine();


        }
    }
}
