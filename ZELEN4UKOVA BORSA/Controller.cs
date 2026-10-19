using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZELEN4UKOVA_BORSA
{
    public class Controller
    {
        private Zelenchukov_market market;
        private Display display;


        public Controller()
        { 
        this.market=new Zelenchukov_market();
        this.display=new Display();
        }
        public void Run()
        {
        //vhod na dannite vurhu Display
        market.zelenchukcenazakg=display.ReadZelen4ukCena();
        market.cqlkgzelenchuci=display.ReadZelen4ukKg();
        market.plodovecenazakg= display.ReadPlodoveCena();
        market.cqlkgplodove=display.ReadPlodoveKg();
        //iz4islqvane na sumata
        double resultINEuro=market.CalculatetotalEuro();
        //izhod 4rez Display
        display.PrintRezultat(resultINEuro);
        }
    }
}
