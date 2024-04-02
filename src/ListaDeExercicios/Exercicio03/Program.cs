namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                double kmInicial;
                double kmFinal;
                double litrosConsumidos;
                double media;


                Console.WriteLine("Digite a Quilometragem inicial: ");
                kmInicial = Double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a Quilometragem final: ");
                kmFinal = Double.Parse(Console.ReadLine());

                Console.WriteLine("Digite quantos litros de combustível foi consumido: ");
                litrosConsumidos = Double.Parse(Console.ReadLine());

                media = (kmFinal - kmInicial) / litrosConsumidos;

                Console.WriteLine("A média de litros por KM foi de {0}", media);

                Console.WriteLine("Deseja sair? Digite (sim) para confirmar");

                var resposta = Console.ReadLine();

                if (resposta == "sim")
                {
                    continuar = false;
                }
            }
        }
    }
}
