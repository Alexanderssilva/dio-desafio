using System;
using static System.Console;

namespace trabalhando_tipos_de_referencia_e_valor
{
    public class Program
    {
        static int Adicionar20(int x)
        {
         return x + 20;
        }
        public static void Main()
        {
            int a = 2;
            a = Adicionar20(a);
            WriteLine(a);
        }
    }
}
