using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;


/// <summary>
//
// Nector Juan Luciano Piña
// Matrícula(17-MIIN-1-052)
// Sección 0463
//
/// </summary>
namespace Conversion_de_Decimal
{
    class Program
    {

        static void Main(string[] args) 
        {

            int seleccion, numero, binario, octal, hexadecimal;
            int x;

            Console.Clear();
            //Bucle de Retorno
            do
            {
                do
                {

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Nector Juan Luciano Piña\t");
                    Console.Write("Matrícula(17-MIIN-1-052)\t");
                    Console.Write("Sección 0463\t\n\n");
                    Console.WriteLine("\t\t\t\t CONVERSION DE NUMEROS\n");
                    Console.WriteLine("Introducir Numero decimal a Convertir:  ");
                    Console.WriteLine("----------------------");

                    while (!Int32.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.WriteLine("Opcion Invalida, Intentelo de Nuevo ");
                        /* Si es el valor introducido es correcto saldra del ciclo */
                    }
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t CONVERSION DE NUMEROS\n");
                    Console.WriteLine("SELECCIONE EL TIPO DE CONVERSION\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[1]Binario\t");
                    Console.Write("[2]Octal\t");
                    Console.Write("[3]Hexadecimal\t");
                    Console.Write("[4]Salir\t\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    //métodos son acciones, las propiedades son valores
                    Console.WriteLine("Seleccione:  ");
                    Console.WriteLine("----------------------");

                    while (!Int32.TryParse(Console.ReadLine(), out seleccion))
                    {
                        Console.WriteLine("Opcion Invalida, Intentelo de Nuevo ");
                        /* Si es el valor introducido es correcto saldra del ciclo */
                    }


                    if (seleccion > 4)
                    {
                        Console.WriteLine("Opcion Invalida, Intentelo de Nuevo");

                    }
                    else
                    {

                        switch (seleccion)
                        {
                            case 1:
                                Console.Clear();
                                String resultado = String.Empty;
                                binario = numero;
                                while (binario > 0)
                                {
                                    int resto = binario % 2;
                                    binario = binario / 2;
                                    resultado = resto.ToString() + resultado;
                                }
                                Console.WriteLine("Resultado de la Conversion");
                                Console.Write("El numero " + numero + " Convertido a Binario es Igual: ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(resultado);
                                Console.ForegroundColor = ConsoleColor.White;
                                break;

                            case 2:
                                Console.Clear();
                                resultado = String.Empty;
                                octal = numero;
                                while (octal > 0)
                                {
                                    int resto = octal % 8;
                                    octal = octal / 8;
                                    resultado = resto.ToString() + resultado;
                                }
                                Console.Write("El numero " + numero + " Convertido a Octal es Igual: ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(resultado);
                                Console.ForegroundColor = ConsoleColor.White;
                                break;

                            case 3:
                                Console.Clear();
                                resultado = String.Empty;
                                hexadecimal = numero;
                                //  if ((hexadecimal < 10) && (hexadecimal > 15)) 
                                switch (hexadecimal)
                                {
                                    case 10:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Resultado:");
                                        Console.Write("A\n\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                    case 11:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Resultado:");
                                        Console.Write("B\n\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                    case 12:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("Resultado:");
                                        Console.Write("C\n\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                    case 13:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Resultado:");
                                        Console.Write("D\n\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                    case 14:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Resultado:");
                                        Console.Write("E\n\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                    case 15:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Resultado:");
                                        Console.Write("F\n\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                }
                                while (hexadecimal > 0)
                                {
                                    int resto = hexadecimal % 16;
                                    hexadecimal = hexadecimal / 16;
                                    resultado = resto.ToString() + resultado;
                                }

                                Console.Write("El numero " + numero + " Convertido a Hexadecimal es Igual: ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(resultado);
                                Console.ForegroundColor = ConsoleColor.White;

                                break;

                        }
                    }

                } while (seleccion == 1 || seleccion == 2 || seleccion == 3);
                Console.WriteLine("Realmente desea Salir de la Aplicacion");
                Console.Write("[1]SI\t");
                Console.Write("[2]NO\t");
      
                while (!Int32.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Opcion Invalida, Intentelo de Nuevo ");
                    /* Si es el valor introducido es correcto saldra del ciclo */
                }

                if (x == 1)
                {
                    Environment.Exit(0);
                }
                Console.Clear();
            } while (x == 2);
        }
    }
}
