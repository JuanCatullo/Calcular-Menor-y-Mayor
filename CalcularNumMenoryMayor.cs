using System;

namespace CalcularMayor_Menor
{
    class Program           
    {
        static int calculamayor (int n1, int n2, int n3)
        {
            int may;
            if (n1 > n2 && n1 > n3)
            {
                may = n1;
            }
            else
            if (n2 > n1 && n2 > n3)
            {
                may = n2;
            }
            else
            {
                may = n3;
            }
            return may;
        }

        static int calculamenor(int n1, int n2, int n3)
        {
            int men;
            if (n1 < n2 && n1 < n3)
            {
                men = n1;
            }
            else
                if (n2 < n1 && n2 < n3)
            {
                men = n2;
            }
            else
            {
                men = n3;
            }
            return men;
        }

        static void Main(string[] args)
        {
            string linea;
            int v1, v2, v3, mayor, menor;
            Console.WriteLine("Ingrese el primer numero:");
            linea = Console.ReadLine();
            v1 = int.Parse(linea);
            Console.WriteLine("Ingrese el seguno numero:");
            linea = Console.ReadLine();
            v2 = int.Parse(linea);
            Console.WriteLine("Ingrese el tercer numero:");
            linea = Console.ReadLine();
            v3 = int.Parse(linea);
            mayor = calculamayor(v1, v2, v3);
            menor = calculamenor(v1, v2, v3);
            Console.WriteLine("El mayor es: " + mayor);
            Console.WriteLine("El menor es: " + menor);

            Console.ReadKey();






        }
    }
}
