namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                double altura;
                double largura;
                double comprimento;
                double resultado;

                Console.WriteLine("Digite a altura da caixa: ");
                altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a largura da caixa: ");
                largura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o comprimento da caixa: ");
                comprimento = Convert.ToDouble(Console.ReadLine());

                resultado = altura * largura * comprimento;

                Console.WriteLine($"O volume ocupado pela caixa é de {resultado} unidades cubicas");

                Console.WriteLine("Deseja sair? Digite (sim) ou (s)");

                var resposta = Console.ReadLine();

                if (resposta == "sim" || resposta == "s")
                {
                    continuar = false;
                }
            }
        }
    }
}
