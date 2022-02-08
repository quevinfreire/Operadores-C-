using System;
namespace _01Operadores
{
    class Soma
    {   
        public int n1,n2;
        private int soma()
        {
            return n1 + n2;
        }
        public void mensagem()
        {
            int calculoSoma = soma();
            Console.WriteLine("O resultado da soma é: "+calculoSoma);
        }
        
    }
}