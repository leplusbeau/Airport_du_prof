using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Entities;

namespace Airport.Models
{
    class ModelNatif: AbstractModel
    {
        public List<Vol> Vols = new List<Airport.Entities.Vol>();

        public ModelNatif()
        {
            Vol v1 = new Vol();
            v1.IdVol = 18620;
            v1.Compagnie = "Lufthansa";
            v1.Ligne = "4253";
            v1.JourExploitation = 18;
            v1.Statut = StatutVol.Parking;
            v1.TypeAvion = "735";
            v1.Immatriculation = "DABII";
            v1.Parking = "Z04";
            v1.DernierHoraire = new DateTime(2013, 09, 03, 19, 15, 00);
            v1.Banques = new List<string>();
            v1.Banques.Add("BNQ1");
            v1.Banques.Add("BNQ2");
            v1.Itineraires = new List<string>();
            v1.Itineraires.Add("MUC");
            this.Vols.Add(v1);

            List<string> bnqV2 = new List<string>() { "BNQ6", "BNQ7" };
            List<string> itiV2 = new List<string>() { "PEK", "PVG" };
            Vol v2 = new Vol() {IdVol = 125737, Compagnie="Air China", Ligne="934", JourExploitation=19, Statut= StatutVol.Annulé, TypeAvion="343", 
                Immatriculation= "B2389", Parking="Z03", DernierHoraire=new DateTime(2013, 09, 03, 20, 36, 00), Banques=bnqV2, Itineraires=itiV2};
            this.Vols.Add(v2);
        }



        public override Vol GetDetailsVol(int idVol)
        {
            throw new NotImplementedException();
        }

        public override void AddVol(Vol vol)
        {
            throw new NotImplementedException();
        }

        public override List<Vol> GetVols()
        {
            throw new NotImplementedException();
        }

        public override List<Vol> GetVols(string cie, string line, DateTime debut, DateTime fin)
        {
            throw new NotImplementedException();
        }

        public override List<Vol> GetVols(CriteresVol criteres)
        {
            throw new NotImplementedException();
        }
    }
}
