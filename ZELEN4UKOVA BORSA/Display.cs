using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZELEN4UKOVA_BORSA
{
    public class Display
    {
       public double ReadZelen4ukCena()
       {
        Console.WriteLine("vuvedi cena na kg za zelen4ucite-");
        return double.Parse(Console.ReadLine());
       }
        public int ReadZelen4ukKg()
        {
            Console.WriteLine("vuvedi obshto kg za zelen4ucite-");
            return int.Parse(Console.ReadLine());
        }
        public double ReadPlodoveCena()
        {
            Console.WriteLine("vuvedi cena na kg za plodovete-");
            return double.Parse(Console.ReadLine());
        }
        public int ReadPlodoveKg()
        {
            Console.WriteLine("vuvedi obshto kg za plodovete-");
            return int.Parse(Console.ReadLine());
        }
        public void PrintRezultat(double rezultat)
        {
            Console.WriteLine($"prihodi v evro-{rezultat:F2}");
        }
          
    }
}
