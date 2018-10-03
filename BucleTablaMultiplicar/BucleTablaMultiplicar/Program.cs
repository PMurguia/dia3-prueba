using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleTablaMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //int num;
            //Console.WriteLine("Dame un número y te mostraré su tabla de multiplicar. ");
            //num = Int32.Parse(Console.ReadLine());


            //while (i <= 10)
            //{
            //    Console.WriteLine(num + " x " + i + " = " + (num * i));
            //    i++;
            //}
            //Console.ReadLine();
            //Console.WriteLine();

            //int i1 = 1;

            //while (i1 <= 100)
            //{
            //    Console.Write(" " + i1);
            //    i1++;
            //}
            //Console.ReadLine();

            //int i2 = 1;
            //do
            //{
            //    Console.Write(" " +i2);
            //    i2++;
            //}
            //while (i2 <= 100);
            //Console.ReadLine();

            //int i3;
            //do
            //{

            //    Console.WriteLine("Introduce un número. ");
            //    i3 = Int32.Parse(Console.ReadLine());
            //}
            //while (i3 >= 0);
            //Console.WriteLine("Número negativo. ");
            //Console.ReadLine();

            //int i3;
            //Console.WriteLine("Introduce un número. ");
            //i3 = Int32.Parse(Console.ReadLine());

            //while (i3 >= 0)
            //{

            //    Console.WriteLine("Introduce un número. ");
            //    i3 = Int32.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("Número negativo. ");
            //Console.ReadLine();

            int num, suma=0; // Dos variables, una para los numeros que nos dará el usuario, otra para que se acumulen y sumen esos numeros.
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Dame un número. ");
                num = Int32.Parse(Console.ReadLine());
                suma = num + suma; // Suma de numero introducido "num" y numero guardado previamente "suma"
            }
            Console.WriteLine("Total: " + suma);
            Console.ReadLine();



        }

    }
}
