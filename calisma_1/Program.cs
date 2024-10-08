using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace calisma_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");      // yazdırma böyle yapılır

            string firstname = "Mustafa Kemal";
            string lastname = "Atatürk";
            String fullname= firstname + lastname;   //isimler birleşebilir
            Console.WriteLine(fullname);


            double myDouble = 9.78;
            int myInt = (int)myDouble ;   //değerler aktarılır ama büyük küçüğe aktarılıcaksa böyle parantezle kullanılmalı
            Console.WriteLine(myInt);

            Console.WriteLine(Convert.ToString(myDouble)); // yuvarlama yapılır

            Console.WriteLine("kullanıcı adınızı giriniz");
            string UserName = Console.ReadLine();            // kullanıcı girişi

            int x = 3;
            int y = 5;
            Console.WriteLine(x < y);   // karşılaştırma operatörü

            Console.WriteLine(Math.Min(3,7));    // max bul
            Console.WriteLine(Math.Max(3, 7));   // min bul
            Console.WriteLine(Math.Sqrt(16));  //karekök
            Console.WriteLine(Math.Abs(-4)); //pozitif döner
            Console.WriteLine(Math.Round(9.99)); // yuvarlar


            string txt = "ABCD";
            Console.WriteLine("length is " + txt.Length);       // uzunluk hesaplar
            Console.WriteLine( txt.ToLower());             // küçük harflere dönüştürdü

            string name=string.Concat(firstname,lastname);
            Console.WriteLine(name);                             //iki dizi birleşir


            string myString = "Hello";
            Console.WriteLine(myString[0]); // elemanı yazar

            myString.IndexOf("e");  // indexi yazar

            int time = 20;
            string result = (time < 18) ? "Good day" :  "Good evening";   // if kısa hali

            int tmp = 2;

            switch(tmp)
            {
               case 1:
                    Console.WriteLine("haklısın");
                    break;
               case 2: 
                    Console.WriteLine("haksızsın");
                    break;

            }

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" }; // dizi atar
            Array.Sort(cars);  // dizi sıralar

            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };  // 2D dizi oluşturur

            Console.WriteLine(numbers[0,2]);  // 0.satır 2. sütundaki sayıyı yazdırır

            for(int i = 1; i < numbers.GetLength(0); i++)
            {
                for(int j = 0; j < numbers.GetLength(1); j++)
                {                                                         //matrix oluşturur
                    Console.WriteLine(numbers[i, j]);
                }
            }














        }


    }
}
