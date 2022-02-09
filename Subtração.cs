using System;
namespace _01Operadores
{
    class Subtração
    {
        public int n1, n2;
        private int subtracao()
        {
            return n1 - n2;
        } 
        public void mensagem()
        {
            int resultadoSub = subtracao();
            Console.WriteLine("O resultado da subtração é: "+resultadoSub);
        }
    
    }

}