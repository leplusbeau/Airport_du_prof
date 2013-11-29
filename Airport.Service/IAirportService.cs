using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Airport.Entities;

namespace Airport.Service
{
    [ServiceContract]
    public interface IAirportService
    {
        [OperationContract]
        List<Vol> GetAllVols();
        [OperationContract]
        List<Vol> GetVols(DateTime debut, DateTime fin, string cie, int ligne);
        [OperationContract]
        List<Vol> FindVols(CriteresVol criteres);
        [OperationContract]
        void CreateVol(Vol vol);
        [OperationContract]
        Vol GetDetailVol(int idVol);
    }

 
}
