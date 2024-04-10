namespace Exercício09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double peso;
            double imc;

            Console.WriteLine("Digite seu peso: ");
            peso = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            altura = Double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else if (imc >= 18.5 &&  imc < 25)
            {
                Console.WriteLine("Seu peso está normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Você está acima do peso");
            }
            else
            {
                Console.WriteLine("Você está obeso");
            }
        }
    }
}
