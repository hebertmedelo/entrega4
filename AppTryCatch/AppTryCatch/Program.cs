using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTryCatch
{
    class Program
    {

        //Controlar y mostrar el error que captura el catch cuando se intenta dividir por cero, 
        //tambien imprimir la propiedad stack trace de la exepcion.
  
        static void Main(string[] args)
        {
            int numero,resultado ;
            Console.WriteLine("Digite Numero");
            numero = int.Parse(Console.ReadLine());
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
