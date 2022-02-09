using System;
namespace _01Operadores
{
    class Divisao
    {
        public int n1, n2;
        private int divisao()
        {
            return n1 / n2; 
        }
        private int resto()
        {
            return n1 % n2;
        }
        public void mensagem()
        {
            int calculoDiv = divisao();
            int restoDiv = resto();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O resultado da divisão é: "+calculoDiv);
                if (restoDiv == 0)
                {
                   return;
                }
                else 
                    Console.WriteLine("Resto da divisão: "+restoDiv);
        }

    }
}