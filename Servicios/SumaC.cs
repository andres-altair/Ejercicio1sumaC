using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1sumaC.Servicios
{
    internal class SumaC : SumaI
    {
        public void suma(int eleg)
        {
            int n2 = 0;
            int n1;
            for (int i = 0; i <= eleg; i++)  
            {
                n1 = i + n1;
                Console.WriteLine("tu sumatorio es:  " + n1);

            }

        }
    }
}
