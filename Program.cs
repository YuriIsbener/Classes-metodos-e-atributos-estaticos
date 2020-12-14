using System;
using Classes_metodos_e_atributos_estaticos.classes;

namespace Classes_metodos_e_atributos_estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Conversor.DolarParaReais(52) );
            Console.WriteLine( Conversor.RealParaDolar(52) );
            Console.WriteLine( Conversor.EuroParaReal(52) );
            Console.WriteLine( Conversor.RealParaEuro(52) );
        }
    }
}
