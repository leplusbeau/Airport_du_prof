using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Airport.Service
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class AirportService : IAirportService
    {
        //petits int pour pouvoir connaitre nos nombre d'instances
        public static int InstanceEnCours = 0;
        public static int InstanceCrees = 0;
        
        //nouveau constructeur
        public AirportService()
        {
            InstanceEnCours++;
            InstanceCrees++;
        }

        //
        ~AirportService()
        { 
            
        }

        public List<Entities.Vol> GetAllVols()
        {
            try
            {
                return Airport.ModelsFactory.Model.GetVols();
            }
            catch
            {
                throw new FaultException("Bullshit maaaaaaaaaaaaaaaan erreur dans le traitement !!!");
            }
        }

        public List<Entities.Vol> GetVols(DateTime debut, DateTime fin, string cie, int ligne)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Vol> FindVols(Entities.CriteresVol criteres)
        {
            throw new NotImplementedException();
        }

        public void CreateVol(Entities.Vol vol)
        {
            throw new NotImplementedException();
        }

        public Entities.Vol GetDetailVol(int idVol)
        {
            throw new NotImplementedException();
        }
    }
}
