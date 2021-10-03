using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skatteberegner
{
    public class Beregning
    {
        // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
        public double SkatVedJulegave(double julegave, double andenGave)
        {
            double ret = 0;
            double samletPris = julegave + andenGave;
            if (julegave <= 1200 && andenGave == 0)
            {
                //hvis anden gave er 0, saa maa julegaven godt være 1200
                ret = 0;
            }
            else if (julegave <= 900 && samletPris <= 1200)
            {
                ret = 0;
            }
            else if(julegave <= 900 && samletPris > 1200)
            {
                ret = andenGave;
            }
            else
            {
                ret = samletPris;
            }

            return ret;
        }
    }
}
