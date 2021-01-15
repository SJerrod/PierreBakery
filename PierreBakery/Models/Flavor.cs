using System.Collections.Generic;

namespace PierreBakery.Models
{
    public class FlavorTreat
    {
        public Flavor()
        {
            this.JoinEntries = new HashSet<FlavorTreat>();
        }

        public int FlavorId { get; set; }
        public string type { get; set; }
        public ICollection<FlavorTreat> JoinEntries { get; set; }
    }
}