// See https://aka.ms/new-console-template for more information

namespace Tarea1
{
    class Arreglos
    {
        static void Main(string[] args)
        {
            int[] arreglo1 = new int[3];

            arreglo1[0] = 9;
            arreglo1[1] = 2;
            arreglo1[2] = 7;


            int[] arreglo2 = new int[3];

            arreglo2[0] = 5;
            arreglo2[1] = 6;
            arreglo2[2] = 1;

            int[] arreglo3 = new int[6];

            arreglo3[0] = arreglo1[0];
            arreglo3[1] = arreglo1[1];
            arreglo3[2] = arreglo1[2];
            arreglo3[3] = arreglo2[0];
            arreglo3[4] = arreglo2[1];
            arreglo3[5] = arreglo2[2];

            List<int> valoresOrdenados = arreglo3.OrderByDescending(x => x).ToList();

            foreach (int valor in valoresOrdenados)
            {
                Console.WriteLine(valor);
            }



        }
    }
}
