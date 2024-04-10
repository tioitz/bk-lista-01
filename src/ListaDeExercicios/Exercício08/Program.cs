namespace Exercício08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero;
            int segundoNumero;
            int terceiroNumero;

            Console.WriteLine("Digite o primeiro número: ");
            primeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: "); 
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            terceiroNumero = Convert.ToInt32(Console.ReadLine());

            int temp;

            if (primeiroNumero < segundoNumero)
            {
                temp = segundoNumero;
                segundoNumero = primeiroNumero;
                primeiroNumero = temp;
            }
            if ( primeiroNumero < terceiroNumero)
            {
                temp = terceiroNumero;
                terceiroNumero = primeiroNumero;
                primeiroNumero = temp;

            }
            if (segundoNumero < terceiroNumero)
            {
                temp = terceiroNumero;
                terceiroNumero = segundoNumero;
                segundoNumero = temp;
            }

            string resultado = $"{primeiroNumero} , {segundoNumero} , {terceiroNumero}";
            Console.WriteLine($"{resultado}");
  
        }
    }
}
