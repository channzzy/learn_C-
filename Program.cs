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

using System;
namespace SkilvulLearning
{
    class DayDua{
        public static void Main(string[] args)
        {
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
            
            
        }
    }
}