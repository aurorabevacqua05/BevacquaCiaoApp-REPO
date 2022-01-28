using System;

namespace BevacquaCiaoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dimmi il tuo nome:");
            string nome = Console.ReadLine();
            Console.Write("Ciao " + nome);
        }
    }
}
