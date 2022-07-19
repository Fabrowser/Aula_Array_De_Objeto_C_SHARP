using System;

namespace Vetor_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco_medio=0;
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do produto: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o preço do produto: ");
                double preco = double.Parse(Console.ReadLine());
                vect[i] = new Produto
                {
                    Name = nome,
                    Price = preco
                };

                preco_medio += preco/n;

            }

            Console.WriteLine("Preço médio = " + preco_medio);


        }
    }
}
