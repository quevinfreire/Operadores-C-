using System;
namespace _01Operadores
{
    class Multiplicacao
    {   
        public int n1, n2;
        private int multiplicacao()
        {
            return n1 * n2;
        }
        public void mensagem()
        {
            int calculoMulti = multiplicacao();
            Console.WriteLine("O resultado da multiplicação é: "+calculoMulti);
        }
    }
}