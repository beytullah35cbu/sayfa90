
using System;
/* 1 – 99 arasında pozitif sayı olduğunu kontrol ettiriniz.
Eğer girilen sayı gerekli şartı sağlamıyor ise programın “Uygun değer girmediniz” mesajı ile sonlanmasını sağlayınız.*/
namespace or214
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz: ");
            //bır if else ile kontrol sagladım
            if (int.TryParse(Console.ReadLine(), out int a) && a >= 1 && a <= 99) //kısıtladım
            {
                string s = " ";
                string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
                string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };

                if (a / 10 >= 1)
                {
                    s = Onlar[(a / 10) - 1];
                }

                if (a % 10 != 0)
                {
                    s = s + Birler[(a % 10) - 1];
                }

                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Uygun değer girmediniz.");
            }

            Console.ReadKey(true);
        }
    }
}



//------------------değiştirecek kod aşağıda--------------------

/*

using System;
namespace or214
{
    class Program
    {
        public static void Main(string[] args)
        {
            byte a;
            string s = " ";
            string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            Console.Write("Bir Sayı Giriniz: ");//72 – 80 – 6
            a = Byte.Parse(Console.ReadLine());
            if (a / 10 >= 1)
            { //Sayı iki veya daha fazla basamaklı mı?
                s = Onlar[(a / 10) - 1];
            }//s= yetmiş – seksen -
            if (a % 10 != 0)
            { //Sayının son basamağı sıfır değilse yaz
                s = s + Birler[(a % 10) - 1];
            }//s= yetmiş+iki – “ altı”
            Console.WriteLine(s);//yetmişiki – seksen – “ altı”
      
            Console.ReadKey(true);
        }
    }
}

*/