namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double primeiraProva;
            double segundaProva;
            double media;
            double pesoDaProvaUm;
            double pesoDaProvaDois;

            Console.WriteLine("Digite a nota da primeira prova: ");
            primeiraProva = Double.Parse(Console.ReadLine());

            pesoDaProvaUm = primeiraProva * 0.6;

            Console.WriteLine("O peso da primeira prova é {0}", pesoDaProvaUm);    

            Console.WriteLine("Digite a nota da segunda prova: ");
            segundaProva = Double.Parse(Console.ReadLine());

            pesoDaProvaDois = segundaProva * 0.6;

            Console.WriteLine("O peso da segunda prova é {0}", pesoDaProvaDois);

            media = (pesoDaProvaUm) + (pesoDaProvaDois);

            if(media > 10)
            {
                media = 10;
            }

            Console.WriteLine("A média final é {0}", media);
            Console.ReadLine();
        }
    }
}
