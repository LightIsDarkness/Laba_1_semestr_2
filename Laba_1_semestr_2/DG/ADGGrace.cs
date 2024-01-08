using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_semestr_2
{
    public class ADGGrace : IDG
    {
        public string Name { get; set; } = "DGGrace";
        public bool Grace { get; set; } = true;
        public bool Expensive { get; set; }
        public bool Convenience { get; set; } 
    }
}
