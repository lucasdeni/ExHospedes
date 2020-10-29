using System;

namespace ExHospedes
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospedes[] vect = new Hospedes[10];
            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel # {i}: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quartos: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Hospedes(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
        }
    }
}
