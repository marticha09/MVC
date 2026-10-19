using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZELEN4UKOVA_BORSA
{
    internal class Zelenchukov_market
    {
        public double zelenchukcenazakg{ get; set; }
        public double plodovecenazakg{ get; set; }
        public int cqlkgzelenchuci{  get; set; }
        public int cqlkgplodove{  get; set; }

        private const double EuroRate = 1.94;

        public double CalculatetotalEuro()
        {
            double totalINBGN=(zelenchukcenazakg*cqlkgzelenchuci)+(plodovecenazakg*cqlkgplodove);
            double totalINEUR = totalINBGN / EuroRate;
            return totalINEUR;  
        }
         

    }
}
