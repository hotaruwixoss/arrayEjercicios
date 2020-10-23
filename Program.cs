using System;
using System.Linq;

namespace arraysEjercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEjercicio 1:");

            /*Un programa que pida al usuario 4 números, los memorice (utilizando un
            array), calcule su media aritmética y después muestre en pantalla la media y
            los datos tecleados.*/

            int[] num = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"ingresa un número {i} : ");
                num[i] = UInt16.Parse(Console.ReadLine());

            }

            Console.ReadLine();
            Console.WriteLine($"Los datos teclados son: ");
            for (int i = 0; i < num.Length; i++)
            {

                Console.WriteLine("El elemento " + (i + 1) + " es igual a: " + (num[i]));
            }
            Console.WriteLine($"\nLa media es: {num.Sum() / num.Length}");

            Console.ReadKey();



            Console.WriteLine("\nEjercicio 2:");

            /*Un programa que pida al usuario 5 números reales (pista: necesitarás un
             array de "float") y luego los muestre en el orden contrario al que se
             introdujeron*/

            float[] numreales = new float[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite un número real: ");


                numreales[i] = Single.Parse(Console.ReadLine());

            }

            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine(numreales[i]);
            }

            Console.ReadKey();



            Console.WriteLine("\nEjercicio 3:");

            /*Un programa que almacene en un array el número de días que tiene cada
              mes (supondremos que es un año no bisiesto), pida al usuario que le
              indique un mes (1=enero, 12=diciembre) y muestre en pantalla el número
              de días que tiene ese mes.  */

            int[] dias = new int[3];

            dias[0] = 28;
            dias[1] = 30;
            dias[2] = 31;

            int[] meses = new int[12];

            meses[0] = dias[1];
            meses[1] = dias[0];
            meses[2] = dias[2];
            meses[3] = dias[1];
            meses[4] = dias[2];
            meses[5] = dias[1];
            meses[6] = dias[2];
            meses[7] = dias[2];
            meses[8] = dias[1];
            meses[9] = dias[2];
            meses[10] = dias[1];
            meses[11] = dias[2];

            Console.WriteLine("Digita un número correspondiente a un mes para saber la cantidad de días que tiene: ");
            int año = Convert.ToInt32(Console.ReadLine());

            //int año = 4;
            switch (año)
            {
                case 1:
                    Console.WriteLine("Enero tiene " + meses[0] + " días");
                    break;
                case 2:
                    Console.WriteLine("Febrero tiene " + meses[1] + " días");
                    break;
                case 3:
                    Console.WriteLine("Marzo tiene " + meses[2] + " días");
                    break;
                case 4:
                    Console.WriteLine("Abril tiene " + meses[3] + " días");
                    break;
                case 5:
                    Console.WriteLine("Mayo tiene " + meses[4] + " días");
                    break;
                case 6:
                    Console.WriteLine("Junio tiene " + meses[5] + " días");
                    break;
                case 7:
                    Console.WriteLine("Julio tiene " + meses[6] + " días");
                    break;
                case 8:
                    Console.WriteLine("Agosto tiene " + meses[7] + " días");
                    break;
                case 9:
                    Console.WriteLine("Septiembre tiene " + meses[8] + " días");
                    break;
                case 10:
                    Console.WriteLine("Octubre tiene " + meses[9] + " días");
                    break;
                case 11:
                    Console.WriteLine("Noviembre tiene" + meses[10] + " días");
                    break;
                case 12:
                    Console.WriteLine("Diciembre tiene " + meses[11] + " días");
                    break;

            }


            Console.WriteLine("\nEjercicio 4:");

            /*. Un programa que pida al usuario 10 números y luego calcule y muestre cuál
                es el mayor de todos ellos.*/

            int[] numB = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"ingresa un número {i} : ");
                numB[i] = UInt16.Parse(Console.ReadLine());

            }

            Console.WriteLine($"\nEl número mayor es: {numB.Max()}");



            Console.WriteLine("\nEjercicio 5:");

            /* Un programa que prepare espacio para un máximo de 100 nombres. El
               usuario deberá ir introduciendo un nombre cada vez, hasta que se pulse
               Intro sin teclear nada, momento en el que dejarán de pedirse más nombres
               y se mostrará en pantalla la lista de los nombres que se han introducido.*/

            string[] nombres = new string[100];

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Escribe un nombre{i}: ");
                nombres[i] = Console.ReadLine();

            }

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }

            Console.ReadKey();

            Console.WriteLine("Fin de los ejercicios, gracias por su tiempo.");
            Console.ReadLine();
        }
    }
}
