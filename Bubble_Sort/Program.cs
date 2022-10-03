using System;
namespace Bubble_Sort
{
    class Program
    {
        //deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        //deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //fungsi atau method untuk menerima masukan
        public void read()
        {
            //menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("------------------------");

            //pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }

        public void display()
        {
            //meanmpilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }

        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) //for n - i passes
            {
                //pada pass i, bandingkan n - i elemen pertama dengan eleemn selanjutnya
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + i]) //jika elemen tidak dalam urutan yang benar
                    {
                        //tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            //creating the object of the BubbleSort Class
            Program myList = new Program();

            //pemanggilan fungsi untuk menerima elemen array
            myList.read();

            //pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();

            //pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();

            //Exit
            Console.WriteLine("\n\nTekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}
