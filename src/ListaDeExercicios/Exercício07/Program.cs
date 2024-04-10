namespace Exercício07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Qual o valor de 'a'? ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o valor de 'b'? ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o valor de 'c'? ");
            c = Convert.ToInt32(Console.ReadLine());

         

            string resultado = (a + b > c) ? "a + b é maior que c" : "a + b é menor que c";
            //{
            //   resultado = "a + b é maior que c";
            //}
            
            Console.WriteLine(resultado);

        }
    }
}
