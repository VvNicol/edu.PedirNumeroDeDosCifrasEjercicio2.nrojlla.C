
namespace edu.numeroEnteroEjercicio2.nrojlla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = PedirNumeroDeDosCifras();

            int sumaMultiplos = 0;
            int contadorMultiplos = 0;

            for (int i = 400; i <= 700; i++)
            {
                if (i % numero == 0)
                {
                    sumaMultiplos += i;
                    contadorMultiplos++;
                    Console.WriteLine(i);
                }
            }
            if (contadorMultiplos > 0)
            {
                double mediaAritmetica = (double)sumaMultiplos / contadorMultiplos;
                Console.WriteLine("La suma de los múltiplos es: " + sumaMultiplos);
                Console.WriteLine("La media aritmética de los múltiplos es:" + mediaAritmetica);
            }
            else
            {
                Console.WriteLine("No se encontraron múltiplos entre 400 y 700.");
            }

        }

        private static int PedirNumeroDeDosCifras()
        {
            int numero;

            do
            {
                Console.Write("Introduce un número entero de dos cifras: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out numero) && entrada.Length == 2)
                {
                    return numero;
                }
                else
                {
                   
                    Console.WriteLine("Error: Debes introducir un número entero de dos cifras. Intenta nuevamente.");
                }

            } while (true);
        }
    }
}
