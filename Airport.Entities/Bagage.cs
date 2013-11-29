using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Entities
{
    public class Bagage
    {
        public string CodeIata { get; set; }
        public int IdTache { get; set; }
        public string Compagnie { get; set; }
        public string Ligne { get; set; }
        public DateTime DateCreation { get; set; }
        public bool CreationDCS { get; set; }
        public List<Trace> TraceBagages { get; set; }
    }
}
