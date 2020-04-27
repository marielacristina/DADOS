using System;

namespace dados
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string email;
            int telefone;
            int rg;

            Console.WriteLine("Entre com os dados");

            Console.ForegroundColor = ConsoleColor.Blue;      // Altera para Azul   
            Console.WriteLine(" Insira o nome");
            Console.ForegroundColor = ConsoleColor.White;    // Altera a cor para Branco
            nome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;      // Altera para Azul
            Console.WriteLine(" Insira o email");
            Console.ForegroundColor = ConsoleColor.White;    // Altera a cor para Branco
            email = Console.ReadLine();    

            Console.ForegroundColor = ConsoleColor.White;    // Altera a cor para Branco
            Console.WriteLine("Insira o telefone");
            Console.ForegroundColor = ConsoleColor.White;    // Altera a cor para Branco
            int.TryParse(Console.ReadLine(), out telefone);

            Console.ForegroundColor = ConsoleColor.White;    // Altera a cor para Branco
            Console.WriteLine("Insira o RG");
            Console.ForegroundColor = ConsoleColor.White;   // Altera a cor para Branco
            int.TryParse(Console.ReadLine(), out rg);

            Console.WriteLine("----------->");

          


            Console.ResetColor(); // Volta a cor padrão. 
            Console.WriteLine(nome);
            Console.WriteLine(email);
            Console.WriteLine(telefone);
            Console.WriteLine(rg);

            Console.ReadKey();
        }
    }
}
