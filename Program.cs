using System;
namespace _01Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma s = new Soma();
            Multiplicacao m = new Multiplicacao();
            Divisao d = new Divisao();
            Subtração sb = new Subtração();

            Console.WriteLine("-------Escolha uma operação para dois números inteiros------");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Multiplicação");
            Console.WriteLine("3- Divisão");
            Console.WriteLine("4- Subtração");
            int escolhaUsuario = int.Parse(Console.ReadLine());
            
            switch (escolhaUsuario)
            {
                case 1:
                    
                    Console.WriteLine("Digite o primeiro número: ");
                    s.n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    s.n2 = int.Parse(Console.ReadLine());
                    s.mensagem();
                
                    break;

                case 2:

                    Console.WriteLine("Digite o primeiro número: ");
                    m.n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    m.n2 = int.Parse(Console.ReadLine());
                    m.mensagem();

                    break;
                
                case 3:

                    Console.WriteLine("Digite o primeiro número: ");
                    d.n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    d.n2 = int.Parse(Console.ReadLine());
                    d.mensagem();

                    break;

                case 4: 
                    Console.WriteLine("Digite o primeiro número: ");
                    sb.n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    sb.n2 = int.Parse(Console.ReadLine());
                    sb.mensagem();

                    break;

                default:
                    throw new ArgumentOutOfRangeException("Dado inválido!");
            }
        }
        
    }
}
