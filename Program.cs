using System;

namespace activ._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma=0, contador=0, d;
            int [] diames = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            string [] mes = {" ", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            Console.WriteLine("Ingrese del 1 al 12 del mes para saber cuantos dias falta desde ese mes");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el dia, desde el cual desea contar los dias restante que queda del año");
            d=Convert.ToInt32(Console.ReadLine());

            for (int i = n; i < diames.Length; i++)
            {
            
            contador=contador+diames[i];
            
            }
            
            for (int j = n; j < mes.Length; j++)
            {
                if(n==j)
                {
                suma=contador-d;
                
                Console.WriteLine("Mes {0} = {1} dia {2} le falta {3}  Dias para terminar el año ", n,mes[j],d, suma);
                }
            }
        }
    }
}
