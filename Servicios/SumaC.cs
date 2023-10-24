using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1sumaC.Servicios
{
    internal class SumaC : SumaI
    {
        public void suma(int n1)
        {
            int n2;
            for (int i = 0; i <= n1; i++)  
            {
                n2 += i;
              
            }
            Console.WriteLine(n2"="i+);

        }
    }
}
