using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colletta
{
    public class Soldi
    {
        public double importo;
        public string valuta;


        public double Importo { get; set; }
        public string Valuta { get; set; }



        public Soldi(double importo, string valuta)
        {
            Importo = importo;
            Valuta = valuta;
           
        }



    }
}
