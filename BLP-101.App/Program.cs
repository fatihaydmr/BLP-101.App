using System.Runtime.CompilerServices;

namespace BLP_101.App
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Kaç tane öğrenci kaydetmek istiyorsunuz:");
            byte ogrenci_adet = byte.Parse(Console.ReadLine());

            long[,] ogrenci_no=new long[ogrenci_adet,7];
            string[,] ogrenci_ad=new string[ogrenci_adet,7];
            string[,] ogrenci_soyad=new string[ogrenci_adet,7];
            float[,] vize=new float[ogrenci_adet,7];
            float[,] final=new float[ogrenci_adet,7];
            float[,] ortalama=new float[ogrenci_adet,7];
            string[,] harf_notu=new string[ogrenci_adet,7];
            float sınıf_ortalama = 0;

            for (int i = 0; i < ogrenci_adet; i++)
            {
                try
                {
                    Console.Write(i + 1 + ". öğrencinin okul numarasını girin:");
                    ogrenci_no[i, 0] = long.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Hata Oluştu! SAYISAL BİR DEĞER GİRİN\nHata Mesajı: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("HATA OLUŞTU!");
                }
                
                while (ogrenci_no[i,0]==0)
                {
                    try
                    {
                        Console.Write(i + 1 + ". öğrencinin okul numarasını girin:");
                        ogrenci_no[i, 0] = long.Parse(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Hata Oluştu! SAYISAL BİR DEĞER GİRİN\nHata Mesajı: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("HATA OLUŞTU!\nHata mesajı:"+ex.Message);
                    }

                }
                


                Console.Write(i + 1 + ". öğrencinin adını girin:");
                ogrenci_ad[i,1] = Console.ReadLine();
      
                Console.Write(i + 1 + ". öğrencinin soyadını girin:");
                ogrenci_soyad[i,2] = Console.ReadLine();

                Console.Write(i + 1 + ". öğrencinin vize notunu girin:");
                vize[i, 3] = float.Parse(Console.ReadLine());
                while (vize[i,3] < 0 || vize[i,3] > 100)
                {
                    Console.WriteLine("Vize notu 0-100 aralığında olmalıdır!");
                    Console.Write(i + 1 + ". öğrencinin vize notunu girin:");
                    vize[i,3] = float.Parse(Console.ReadLine());
                }

                Console.Write(i + 1 + ". öğrencinin final notunu girin:");
                final[i,4] = float.Parse(Console.ReadLine());
                while (final[i,4] < 0 || final[i,4] > 100)
                {
                    Console.WriteLine("Final notu 0-100 aralığında olmalıdır!");
                    Console.Write(i + 1 + ". öğrencinin final notunu girin:");
                    final[i,4] = float.Parse(Console.ReadLine());
                }

                Console.WriteLine();

                ortalama[i,5] = vize[i,3] * 4 / 10 + final[i,4] * 6 / 10;

                sınıf_ortalama += ortalama[i, 5];

                if (ortalama[i,5] >= 85 && ortalama[i,5] <= 100)
                {
                    harf_notu[i,6] = "AA";
                }
                else if (ortalama[i,5] >= 75 && ortalama[i,5] < 85)
                {
                    harf_notu[i,6] = "BA";
                }
                else if (ortalama[i,5] >= 60 && ortalama[i,5] < 75)
                {
                    harf_notu[i,6] = "BB";
                }
                else if (ortalama[i,5] >= 50 && ortalama[i,5] < 60)
                {
                    harf_notu[i,6] = "CB";
                }
                else if (ortalama[i,5] >= 40 && ortalama[i,5] < 50)
                {
                    harf_notu[i,6] = "CC";
                }
                else if (ortalama[i,5] >= 30 && ortalama[i,5] < 40)
                {
                    harf_notu[i,6] = "DC";
                }
                else if (ortalama[i,5] >= 20 && ortalama[i,5] < 30)
                {
                    harf_notu[i,6] = "DD";
                }
                else if (ortalama[i,5] >= 10 && ortalama[i,5] < 20)
                {
                    harf_notu[i,6] = "FD";
                }
                else
                {
                    harf_notu[i,6] = "FF";
                }


            }
            Console.WriteLine();
           
            for (int i = 0; i < ogrenci_adet; i++)
            {
                Console.WriteLine(i+1+")"+ogrenci_no[i,0] + " - " + ogrenci_ad[i, 1] + " " + ogrenci_soyad[i, 2] + " - Vize:" + vize[i, 3] + " - Final:" + final[i,4] + " - Ortalama:" + ortalama[i,5] + " - Harf Ortalaması:" + harf_notu[i,6]);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Sınıf ortalaması:"+sınıf_ortalama/ogrenci_adet);

            float en_kucuk=ortalama[0,5];
            for (int i = 0; i < ogrenci_adet; i++)
            {
                if (ortalama[i,5]<en_kucuk)
                {
                    en_kucuk = ortalama[i, 5];
                }
            }
            Console.WriteLine("En düşük not:"+en_kucuk);

            float en_buyuk = ortalama[0, 5];
            for (int i = 0; i < ogrenci_adet; i++)
            {
                if (ortalama[i,5]>en_buyuk)
                {
                    en_buyuk=ortalama[i, 5];
                }
            }
            Console.WriteLine("En yüksek not:"+en_buyuk);

            
            Console.ReadLine();
        }
    }
}
