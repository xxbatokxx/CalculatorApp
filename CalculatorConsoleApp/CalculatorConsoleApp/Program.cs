using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            //int a = 10; // declarasi variabel a, dengan nilai awal 10;
            //int b = 6; // declarasi variabel b, dengan nilai awal 6;


            
            Console.Write("Pilih menu calculator : \n");
            Console.Write("1. Penjumlahan\n");
            Console.Write("2. Pengurangan\n");
            Console.Write("3. Pembagian\n");
            Console.Write("4. Perkalian\n");
            Console.WriteLine();

            Console.WriteLine("Input nomer menu [1..4]: ");
            
            int menu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); // proses casting

            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine()); // proses casting

            Console.WriteLine(); // tambahkan baris kosong

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Hasil penjumlahan " + a + " + " + b + " = " + penambahan(a, b));
                    break;
                case 2:
                    Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                    break;
                case 3:
                    Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
                    break;
                case 4:
                    Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
                    break;
                default:
                    Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
                    break;
            }

                    Console.WriteLine("\nTekan sembarang key untuk keluar");
                    Console.ReadKey();
            }
        

        static int penambahan(int a, int b) {
            return a + b;
        }

        static int pengurangan(int a, int b) {
            return a - b;
        }

        static int perkalian(int a, int b){
            return a * b;
        }

        static int pembagian(int a, int b){
            return a / b;
        }
    }
}
