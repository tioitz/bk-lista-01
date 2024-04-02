namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBase;
            double vendas;
            double comissao = 2.5;
            double salarioFinal;

            Console.WriteLine("Qual o seu salário base?");
            salarioBase = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor total de suas vendas no mês: ");
            vendas = Double.Parse(Console.ReadLine());

            comissao = (vendas * 0.025); 
            salarioFinal = (comissao + salarioBase);

            Console.WriteLine("Seu sálario esse mês será de R${0}", salarioFinal);
            Console.ReadLine();
        }
    }
}
