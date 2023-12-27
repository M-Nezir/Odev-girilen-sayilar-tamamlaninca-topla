using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_girilen_sayilar_tamamlaninca_topla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ÖDEV: Öyle bir program yazın ki, önce kullanıcıya kaç adet sayı girmek istediğini sorsun.
               Daha sonra kullanıcıdan sayı girmesini istesin. Kullanıcı fark etse de etmese de baştan 
             girdiği adet kadar sayı tamamlandığında bu sayıların toplamını ve ortalamasını hesaplayarak ekrana yazsın.*/


            Console.WriteLine("kaç adet sayıyı toplamak istersiniz: ");
            int adet = Convert.ToInt32(Console.ReadLine());

            

           double toplam = 0 , newtoplam = 0;

            for (int i = 0; adet - 1 >= i; i++)
            {

                
                Console.WriteLine($"lütfen toplamak istediğiniz sayılardan {i+1}. sayıyı giriniz:");
                int sayılar = Convert.ToInt32(Console.ReadLine());

                newtoplam = sayılar + toplam;
                toplam = newtoplam;

                
                if (i != adet-1)
                {
                    continue;
                }

                Console.WriteLine($"yazdığınız sayıların toplamı: {toplam}");
                Console.WriteLine($"yazdığnız sayıların ortalaması: {toplam/adet}");

                Console.WriteLine("bitirmek için enter: ");
                Console.ReadLine();

                break;
            }

        }
    }
}
