using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Entities
{
    /// <summary>
    /// Cette classe definie un vol
    /// </summary>
    public class Vol
    {
        public int IdVol { get; set; }
        /// <summary>
        /// Nom de la compagnie
        /// </summary>
        public string Compagnie {get; set; }
        public string Ligne{get;set;}
        public int JourExploitation { get; set; }
        public StatutVol Statut { get; set; }
        public string TypeAvion { get; set; }
        public string Immatriculation { get; set; }
        public string Parking { get; set; }
        public DateTime DernierHoraire { get; set; }
        public string OrigineCreation { get; set; }
        public List<string> Itineraires { get; set; }
        public List<string> Banques { get; set; }
        
    }

    public class CriteresVol
    {

    }
}
