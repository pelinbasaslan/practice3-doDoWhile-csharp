using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        /*
        Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.
        ( Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )
        Örnek inputlar : 10 ve -5
        Uygulama testi sonrası while ve do-while arasındaki farkı yorum satırı olarak kodunuzun altına ekleyiniz.
        */

        //WHILE

        int i = 0;
        Console.Write("Lütfen bir sayı giriniz:");
        int userInput = Convert.ToInt32(Console.ReadLine());
        while (i < userInput)
        {
            Console.WriteLine($" {i + 1}) Ben bir Patika'lıyım.");
            i++;
        }

        //0 ve 0'dan küçük değerlerde direkt çalışmıyor.

        int i2 = 0;
        int userInput2 = 0;
        while (userInput2 <= 0)
        {
            Console.Write("Bir sayı giriniz:");
            userInput2 = Convert.ToInt32(Console.ReadLine());
            if (userInput2 <= 0)
            {
                Console.WriteLine("Lütfen 0'dan büyük bir sayı giriniz.");
            }
        }
        while (i2 < userInput2)
        {
            Console.WriteLine($" {i2 + 1}) Ben bir Patika'lıyım.");
            i2++;
        }

        /*
        Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.
        ( Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )
        Örnek inputlar : 10 ve -5
        Uygulama testi sonrası while ve do-while arasındaki farkı yorum satırı olarak kodunuzun altına ekleyiniz.
        */

        //DO WHILE

        int userInput3 = 0;
        int sayac = 0;
        Console.Write("Bir sayı giriniz:");
        userInput3 = Convert.ToInt32(Console.ReadLine());
        do
        {
            Console.WriteLine($" {sayac}) Ben bir Patika'lıyım.");
            sayac++;
        } while (sayac <= userInput3);

        //Kullanıcı 0 ve 0'dan küçük bir değer verdiği zaman koşula bakmaksız bir defalığına do scopeunu çalıştırıyor. Sonra koşul kontrol ediliyor ve bu koşul sağlanmıyorsa çalışmıyor.

        //- değer için de 0'dan büyük sayı verene kadar çalışan: 


        int userInput4 = 0;

        do
        {

            Console.Write("Bir sayı giriniz:");
            userInput4 = Convert.ToInt32(Console.ReadLine());
            if (userInput4 <= 0)
            {
                Console.WriteLine("Lütfen 0'dan büyük bir sayı giriniz.");
            }

        } while (userInput4 <= 0);

        int sayac2 = 0;

        do
        {
            Console.WriteLine($" {sayac2}) Ben bir Patika'lıyım.");
            sayac2++;
        } while (sayac2 <= userInput4);


        /* 
        DO - Do While Farkı
        Do-while döngüsünde döngü en az bir kez çalışır ve sonrasında koşul kontrol edilir. Eğer koşul true ise döngü devam eder, false ise döngü sona erer. While döngüsünde döngüye başlamadan önce koşul kontrol edilir. Eğer koşul false (yanlış) ise, döngü hiçbir zaman çalışmaz.
        

        int sayi;
        Console.WriteLine("Lütfen bir sayı girin: ");
        sayi = Convert.ToInt32(Console.ReadLine());
        while (sayi <= 5)
        {
            Console.WriteLine("Lütfen 5'ten büyük bir sayı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Tebrikler, girdiğiniz sayı 5'ten büyük!");
        
        
        int sayi1;
        do
        {
            Console.WriteLine("Lütfen bir sayı girin: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 <= 5)
            {
            Console.WriteLine("Lütfen 5'ten büyük bir sayı girin.");
            }
        } while (sayi1 <= 5);

        Console.WriteLine("Tebrikler, girdiğiniz sayı 5'ten büyük!");
        */




    }
}