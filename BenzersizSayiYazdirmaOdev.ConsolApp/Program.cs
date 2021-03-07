using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzersizSayiYazdirmaOdev.ConsolApp
{
    class Program
    {
        private static Array value;

        static void Main(string[] args)
        {
            Console.Title = "Rasagele Benzersiz Sayı Üretme Ödevi Süleyman Talha Demir 203801046";
            Console.BackgroundColor = ConsoleColor.Red;
            int[] sirali = new int[0];
            Random rnd = new Random();
            List<int> numList = new List<int>();
            
            while (true)
            {
                
                numList.Clear();
                Console.WriteLine("Lütfen hangi sayılar arasında ne kadar sayı üreteceğinizi \" \" yazarak belirtiniz. Çıkış için \"q\" tuşalayınız örnek[4-20-5 4 ile 20 arası 5 sayı] ");
                string girilen = Console.ReadLine();
                if (girilen == "q") 
                {
                    break;
                }
                int num1 = Convert.ToInt32(girilen.Split('-')[0]);
                int num2 = Convert.ToInt32(girilen.Split('-')[1]);
                int miktar = Convert.ToInt32(girilen.Split('-')[2]);
                
                for (int i = 0; i < miktar; i++)
                {
                    
                    int temp= (rnd.Next(num1, num2));
                    if (numList.Contains(temp))
                    {
                        i--;
                        continue;
                    }
                    else
                    {
                        numList.Add(temp);
                    }
                    
                    foreach (var item in numList)
                    {
                        Console.WriteLine(item+" ");
                    }
                    Array.Sort(sirali);
                    Console.WriteLine();
                }
            }      
        }
    }
}
