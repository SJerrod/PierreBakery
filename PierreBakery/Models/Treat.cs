using System.Collections.Generic;

namespace PierreBakery.Models
{
    public class Treat
    {
        public Treat()
        {
            this.JoinEntries = new HashSet<FlavorTreat>();
        }

        public int TreatId { get; set; }
        public string Name { get; set; }
        public ICollection<FlavorTreat> JoinEntries { get; set; }
    }
}