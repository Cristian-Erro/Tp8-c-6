using System;

namespace Tp8_c_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables y array
            int[] arregloNumeros={12,21,15,23,55,34,33,65,88,19};
            int valor=0;
            bool estaono=false;
            //ingreso valor
            Console.WriteLine("Ingrese un valor");
            valor=Convert.ToInt32(Console.ReadLine());
            //llamo a la funcion
            estaono=buscar(arregloNumeros,valor);
            //mensaje final
            System.Console.WriteLine(estaono==true?"El valor esta":"El valor no esta");
            System.Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
        //funcion de busqueda en array
        private static bool buscar(int[]num,int valor){
            bool estaono=false;
            for(int i=0;i<num.Length;i++){
                if(num[i]==valor){
                    estaono=true;
                }
            }
            return estaono;
        }
    }
}
