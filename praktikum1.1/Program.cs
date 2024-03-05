using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("pilih menu kalkulator :/n");

            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkaliam");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine("Inputkan nilai menu (1-4)");
            int menu = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); // proses casting

            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine()); // proses casting

            if (menu == 1){
                 Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                   } 
            else if (menu == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            } 
            else if (menu == 3)
            {
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            } 
            else if (menu == 4)
            {
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();

        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a + b;
        }
        static int Perkalian(int a, int b)
        {
            return a + b;
        }
        static int Pembagian(int a, int b)
        {
            return a + b;
        }
        // TODO: tambahkan method untuk Perkalian dan Pembagian
    }
}
