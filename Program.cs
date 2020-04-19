using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicacion = 0, numero = 0;
            

            Console.Write("Escriba un numero:");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int cont = 1; cont <= 10; cont ++)
            {
                multiplicacion = numero * cont;
                Console.WriteLine("{0} * {1} = {2}", numero, cont, multiplicacion);
            }

            Console.ReadKey();

            

        }
    }
}
