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
            Console.WriteLine("O resultado da divisão é: "+calculoDiv);
            Console.WriteLine("Resto da divisão: "+restoDiv);
        }

    }
}