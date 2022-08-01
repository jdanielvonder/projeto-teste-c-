    class program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;

            Console.WriteLine("Digite o primeiro valor:");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            valor2 = int.Parse(Console.ReadLine());

            int sum = Sum(valor1, valor2);

            Console.WriteLine(sum);
            Console.ReadKey(true);       
         }
         static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

    }
