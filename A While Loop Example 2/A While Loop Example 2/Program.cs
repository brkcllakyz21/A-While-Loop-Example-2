using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_While_Loop_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad_soyad = " ", kontrol = "E";
            int numara = 0, Vize_1 = 0, Vize_2 = 0, ödev = 0, final = 0;
            double vize_ort = 0, ödev_ort = 0, final_ort = 0, ort = 0;
            bool while_döngüsü = true;
            while (while_döngüsü)
            {
                Console.Write("Öğrencinin adını ve soyadını giriniz : ");
                ad_soyad = Convert.ToString(Console.ReadLine());
                Console.Write(ad_soyad + " öğrencisinin numara giriniz : ");
                numara = Convert.ToInt32(Console.ReadLine());
                Console.Write(numara + " numaralı öğrencinin 1. Vize notunu giriniz : ");
                Vize_1 = Convert.ToInt32(Console.ReadLine());
                Console.Write(numara + " numaralı öğrencinin 2. Vize notunu giriniz : ");
                Vize_2 = Convert.ToInt32(Console.ReadLine());
                Console.Write(numara + " numaralı öğrencinin Ödev notunu giriniz : ");
                ödev = Convert.ToInt32(Console.ReadLine());
                Console.Write(numara + " numaralı öğrencinin Final notunu giriniz : ");
                final = Convert.ToInt32(Console.ReadLine());
                Vize_1 += Vize_2;
                vize_ort = Vize_1 / 2;
                vize_ort *= 3;
                vize_ort /= 10;
                ödev *= 2;
                ödev_ort = ödev / 10;
                final_ort = final * 5;
                final_ort /= 10;
                ort = vize_ort + ödev_ort + final_ort;
                Console.WriteLine("Adı Soyadı " + ad_soyad + " ve numarası " + numara + " olan öğrencinin ortalaması : " + ort);
                Console.Write("Devam etmek için E çıkmak için H tuşuna basınız : ");
                kontrol = Convert.ToString(Console.ReadLine());
                if (kontrol != "E")
                {
                    while_döngüsü = false;
                }
                else
                {
                    while_döngüsü = true;
                }
            }







        }
    }
}
