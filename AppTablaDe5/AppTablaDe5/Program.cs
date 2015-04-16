using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTryCatch
{
    class Program
    {

     //Desarrollar un programa que muestre la tabla de multiplicar del 5 (del 5 al 50) no olvidar el manejo de errores.


        static void Main(string[] args)
        {
            int numero,resultado;
            Console.WriteLine("TABLA DEL 5");
            Console.WriteLine("Digite Numero");
            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1: Console.WriteLine("5 " );
                    break;
                case 2: Console.WriteLine("10 ");
                    break;
                case 3: Console.WriteLine("15 ");
                    break;
                case 4: Console.WriteLine("20 ");
                    break;
                case 5: Console.WriteLine("25 ");
                    break;
                case 6: Console.WriteLine("30 ");
                    break;
                case 7: Console.WriteLine("35 ");
                    break;
                case 8: Console.WriteLine("40 ");
                    break;
                case 9: Console.WriteLine("45 ");
                    break;
                case 10: Console.WriteLine("50 ");
                    break;
            }



            try
            {
                resultado = 5 / numero;

            }
            catch (Exception error)
            {
                Console.WriteLine("el error es: " + error.Message);
            }
            Console.ReadKey();
        }
    }
}
