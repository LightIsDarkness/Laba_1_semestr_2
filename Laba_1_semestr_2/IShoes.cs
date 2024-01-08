using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_semestr_2
{
     public interface IShoes : IThing
    {
        public string Name { get; set; }
        public bool Grace { get; set; }
        public bool Expensive { get; set; }
        public bool Convenience { get; set; }
    }
}
