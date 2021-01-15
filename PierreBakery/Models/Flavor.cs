using System.Collections.Generic;

namespace PierreBakery.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.JoinEntries = new HashSet<FlavorTreat>();
        }

        public int FlavorId { get; set; }
        public string Type { get; set; }
        public virtual ApplicationUser User { get; set; }
        public ICollection<FlavorTreat> JoinEntries { get; set; }
    }
}