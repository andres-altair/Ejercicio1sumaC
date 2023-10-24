using Ejercicio1sumaC;
using Ejercicio1sumaC.Servicios;

namespace Ejercicio1sumaC
{
    class program
    {
        static void Main(string[] args)
        {
            pedirI pI = new pedirC();
            int i = pI.pedir();
            SumaI sI = new SumaC();
            i = sI.suma(int n1);

        }
    }
}


