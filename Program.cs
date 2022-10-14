using System;

namespace algoritma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir adet pozitif sayı girin.");
            int sayi = int.Parse(Console.ReadLine());

            
            string[] kelimeler = new string[sayi];

            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("{0}. kelimeyi giriniz",i+1);
                kelimeler[i] = Console.ReadLine();
            }

            Array.Reverse(kelimeler);
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }
        }
    }
}