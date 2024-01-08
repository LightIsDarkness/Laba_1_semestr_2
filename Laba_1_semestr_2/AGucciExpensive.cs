using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_semestr_2
{
    public class AGucciExpensive : IGucci
    {
        public string Name { get; set; } = "GucciExpensive";
        public bool Grace { get; set; }
        public bool Expensive { get; set; } = true;
        public bool Convenience { get; set; } 
    }
}
