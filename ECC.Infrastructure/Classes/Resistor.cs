using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECC.Infrastructure.Classes
{
    public class Resistor
    {
        public int Id { get; set; }

        public string BandA { get; set; }

        public string BandB { get; set; }

        public string BandC { get; set; }

        public string BandD { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
