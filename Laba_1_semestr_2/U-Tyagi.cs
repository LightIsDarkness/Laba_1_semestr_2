using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_semestr_2
{
    public class U_Tyagi
    {
        public List<IThing> Things = new List<IThing>()
        {
            new Notebook(),
            new ADGConvenience(),
            new ADGExpensive(),
            new ADGGrace(),
            new AGucciConvenience(),
            new AGucciExpensive(),
            new AGucciGrace(),
            new APradaConvenience(),
            new APradaExpensive(),
            new APradaGrace()
        };
    }
}
