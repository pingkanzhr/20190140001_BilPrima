using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilanganprima
{
    /// <summary>
    /// menandakan main class utama
    /// </summary>
    /// <remarks>class ini dapat membuat operasi aritmatika menidentifikasi mana bilangan prima dan mana bukan bil prima</remarks>
    class Program 
    {
        /// <summary>
        /// operasi aritmatika
        /// </summary>
        /// <param name="args">operasi bilangan prima yang akan dikeluarkan</param>
        /// <param name="a">angka pertama dalam operasi bilangan prima</param>
        /// <param name="b">angka kedua dalam operasi bilangan prima</param>
        
        static void Main(string[] args)
        {
            int bil;
            {
                //kondisi awal 
                Console.WriteLine("========= Program untuk Menentukan Bilangan Prima =========");
                Console.WriteLine();
                Console.Write("Masukan Angka: ");
                bil = Convert.ToInt16(Console.ReadLine());
                //operasi hitung bilangan aritmatika prima
                //perulangan for 
                for (int i = 1; i <= bil; i++)
                {
                    int a = 0;

                    for (int b = 2; b <= i / 2; b++)
                    {
                        if (i % b == 0) //jika i modulus b sama dengan 0 (sisa bagi dari i dan b sama dengan 0)
                        {
                            a++; //perulangan
                        }
                    }
                    if (a == 0 && i != 1) 
                    //sebuah kondisi untuk menunjukan bil prima, jika true maka 
                    //akan menunjukan bil prima, jika false maka akan menunjukan bil bukan prima
                       
                    {
                        Console.WriteLine("{0} bilangan prima", i);//hasil jika true
                    }
                    else
                    {
                        Console.WriteLine("{0} bukan bilangan prima", i);//hasil operasi jika false
                    }

                }
                Console.WriteLine("");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit..."); //kondisi untuk exit
            Console.ReadKey();
        }
    }
}
