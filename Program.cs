// See https://aka.ms/new-console-template for more information

//Struktur Dasar Di C#
//
// using System;
// namespace SkilvulLearning
// {
//     class Animal
//     {
//         public static void Main(string[] args)
//         {
//             Console.WriteLine("Animal List");
//             Console.WriteLine("-----------");
//             Console.WriteLine("1. Chciken");
//             Console.WriteLine("2. Duck");
//         }
//     }
// }

//Beberapa Sintaks Di C#

//Sintaks Print
// Console.WriteLine("Hello");
// Console.WriteLine("Hello" + "Hai");
// Console.WriteLine(7);
// Console.WriteLine(7.5);
// Console.WriteLine("November " + 4);
// Console.WriteLine(11 + 4);

// using System;
// namespace SkilvulLearning
// {
//     class DaySatu{
//         public static void Main(string[] args)
//         {
//             //Deklarsi Variable Eksplisit
//             // string nama;
//             // int umur;
//             // Float beratBadan;
//             // bool isMenikah;

//             //Inisialisasi Variable
//             // nama = "Chandra";
//             // umur = 18;
//             // beratBadan = 49.5;
//             // isMenikah = false;

//             //Deklarasi dan Inisialisasi secara langsung
//             // string nama = "Chandra";
//             // int umur = 18;
//             // Console.WriteLine(nama + " berumur " + umur + " tahun");

//             //Deklarasi Variable Implisit
//             // var nama = "Chandra";
//         }
//     }
// }

//Day 2

// using System;
// namespace SkilvulLearning
// {
//     class DayDua{
//         public static void Main(string[] args)
//         {
            // string name = "Chandra";
            //Menggunakan Properti Dalam String
            // Console.WriteLine("panjangnya adalah " + name.Length);

            //Menggunakan method pada string
            // Console.WriteLine("Ubah menjadi kapital " + name.ToUpper());
            // Console.WriteLine("Ubah menjadi kecil " + name.ToLower());

            //Penggabungan dua string / concatenation
            // string lastName = "Ardiansyah";
            // Console.WriteLine( name + lastName);

            //String interpolation
            // Console.WriteLine($"Nama saya adalah : {name} {lastName}");

            //Access string
            // Console.WriteLine(name[0]);

            //Menemukan posisi kararkter dalam string
            // int index = name.IndexOf("n");
            // string subs = name.Substring(index);
            // Console.WriteLine(subs);


            //Spesial Characters
            // Console.WriteLine("It\'s Chanzy");
            // Console.WriteLine("Saya adalah \"Chanzy\"");
            // Console.WriteLine("Saya adalah Chanzy \\ Chandra");
            // Console.WriteLine("Saya adalah Chanzy \nUmur 18 tahun");
            // Console.WriteLine("Cirebon kota \t udang");
            // Console.WriteLine("Cirebon kota \b udang");

            //Input dalam console
            // Console.WriteLine("Silahkan masukan nama anda");
            // Console.WriteLine("=========================");
            // string input = Console.ReadLine();
            // Console.WriteLine($"Nama anda adalah {input}");

            //Convert tipe data
            // int myInt = 9;
            // double myDouble = myInt;       // Automatic casting: int to double

            // Console.WriteLine(myInt);      // Outputs 9
            // Console.WriteLine(myDouble);   // Outputs 9

            // Console.WriteLine(myInt.GetType());
            // Console.WriteLine(myDouble.GetType());

            // double myDouble = 9.78;
            // int myInt = (int) myDouble;    // Manual casting: double to int
            // Console.WriteLine(myInt.GetType());
            // Console.WriteLine(myDouble.GetType());

            // int myInt = 10;
            // double myDouble = 5.25;
            // bool myBool = true;

            // Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            // Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            // Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            // Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            
            
//         }
//     }
// }

//Day 3
// using System;
// namespace SkilvulLearning
// {
//     class Day3{
//         public static void Main(string[] args)
//         {
//             int angka1 = 1;
//             int angka2 = 2;
//             string cuaca = "Hujan";
            //Operator C#
            //Operator Aritmatika
            // Console.WriteLine(angka1 + angka2);
            // Console.WriteLine(angka2 - angka1);
            // Console.WriteLine(angka2 * angka1);
            
            //Operator assigment
            // Console.WriteLine(angka1 += 5);
            // Console.WriteLine(angka2 -= angka1);

            //Operator Perbandingan
            // Console.WriteLine(angka1 < angka2);

            //Operator Logika
            // Console.WriteLine(angka1 < angka2 && angka1 > angka2);

            //Pengkondisian

            //1.If Statment
            // if(angka1 < angka2){
            //     Console.WriteLine("Angka 1 lebih kecil dari angka2");
            // }

            //2.If else statment
            // if(angka1 > angka2){
            //     Console.WriteLine("Angka 1 lebih besar dari angka2");
            // }else{
            //     Console.WriteLine("Angka 1 lebih kecil dari angka2");
            // }

            //3.If else if statment
            // if(angka1 > angka2){
            //     Console.WriteLine("Angka 1 lebih besar dari angka2");
            // }else if(angka1 < angka2 && angka1 != angka2){
            //     Console.WriteLine("Angka 1 lebih kecil dari angka2 dan tidak sama dengan angka 2");
            // }else{
            //     Console.WriteLine("Terjadi kesalahan");
            // }

            //4.Switch
            // switch (cuaca)
            // {
            //     case "Panas":
            //     Console.WriteLine("Tidak usah membawa payung");
            //     break;
            //     case "Hujan":
            //     Console.WriteLine("Membawa payung");
            //     break;
            //     default:
            //     Console.WriteLine("Tidak keluar");
            //     break;
            // }

            //Perulangan
            //1.For
            // int i,j,angka,jumlahDigit;
            // for (i = 0; i < 10; i++)
            // {
            //     Console.WriteLine($"Ini perulangan ke-{i}");
            // }

            //variasi dalam for menggunakan dua variable
            // for (i = 0,j = 10; i < j; i++,j--)
            // {
            //     Console.WriteLine("i dan j: " + i + " " + j);
            // }

            //While
            // angka = 43567424;
		    // jumlahDigit = 0;
            //     Console.WriteLine("Angka: " + angka);
            //     while (angka > 0)
            //     {
            //         jumlahDigit++;
            //         angka = angka / 10;
            //     }

            //     Console.WriteLine("Jumlah Digit: " + jumlahDigit);
            

            //Format for di dalam while
            // int hitung = 10;
            // while (hitung>0)
            // {
            //     Console.WriteLine(hitung + "...");
            //     hitung--;
            // }
            // Console.WriteLine("MULAI!!!");
            // Console.ReadKey();

            //Do while
            // int increment = 10;
            // do
            // {
            //     increment += 1;
            //     Console.WriteLine(increment);
            //     increment -= 2;
            // } while (increment > 0);

            // int increment = 0;
            // while(true)
            // {
            //     increment++;
            //     if(increment % 2 == 0)
            //         continue;
                
            //     if(increment > 10)
            //         break;
            //     else
            //         Console.WriteLine(increment);
            // }
            // int x = 0;
            // int y = 0;

            // for(int i = 0; i < 20; i++)
            // {
            //     x = i * 2;
            //     y = i * 3;
                
            //     if(x * y >= 100)
            //         break;
                
            //     Console.WriteLine(x + " " + y);
            // }

            // for(int i = 0; i < 6; i++)
            // {
            //     for(int j = i; j >= 0; j--) 
            //     {
            //         Console.Write("* "); 
            //     }
            //     Console.WriteLine();
            // }
//     }
// }
// }

//Day 4
using System;
namespace SkilvulLearning
{
    class Day4{
        public static void Main(string[] args)
        {
            //Array
            //Deklarsi array pada C# 
            // int [] arrayAngka;
            // string [] arrayNama;
            // object [] arrayObjek;

            //Memberi nilai pada array
            int [] arrayAngka = new int [5];
            string [] arrayNama = new string [] {
                "Chandra",
                "Haikal",
                "Adrian"
            };
            object [] arrayObjek = {
                "Chandra",
                "Cirebon",
                true,
                20,
            };

            //Mengakses array dengan menggunakan index
            Console.WriteLine(arrayNama[0]);

            //Mengakses array menggunakan perulangan
            for (int i = 0; i <= arrayNama.Length; i++)
            {
                    Console.WriteLine($"Elemen dengan indeks {i} = {arrayNama[i]}");
            }
        }
}
}