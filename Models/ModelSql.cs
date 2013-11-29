using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Airport.Entities;

namespace Airport.Models
{
    class ModelSql : AbstractModel
    {
        private string connectionString = 
"Data Source=PORTABLE-DEV-SI;Initial Catalog=CDG1_EXPLOIT_ADP;Integrated Security=True";
        private string selectVols =
"select v.ID_VOL, c.CODE_CIE as Compagnie, v.LIG as Ligne, v.JEX as JourExploitation, v.STA as Statut, vd.TYP as TypeAvion, "+ 
"vd.IMM as Immatriculation, v.PKG as Parking, v.DHC as DernierHoraire, vd.CRE as OrigineCreation " +
"from vol v inner join VOL_DEPART vd on vd.ID_VOL=v.ID_VOL inner join CIE  c on c.ID_CIE = v.ID_CIE "+
"where v.DHC between @DateDebut and DATEADD(d, 1, @DateDebut)";

        public override List<Entities.Vol> GetVols()
        {
            List<Vol> res = new List<Vol>();
            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(selectVols, cnx);

                    
                    cmd.Parameters.Add("@DateDebut", SqlDbType.DateTime);
                    cmd.Parameters[0].Value = "11/10/2013";
                    cnx.Open();

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            Entities.Vol vol = new Entities.Vol();
                            vol.IdVol = sdr.GetInt32(sdr.GetOrdinal("ID_VOL"));
                            vol.Compagnie = sdr.GetString(sdr.GetOrdinal("Compagnie"));
                            vol.Ligne = sdr.GetString(sdr.GetOrdinal("Ligne"));
                            vol.JourExploitation = sdr.GetInt16(sdr.GetOrdinal("JourExploitation"));
                            switch(sdr.GetString(sdr.GetOrdinal("Statut")))
                            {
                                case "ANN":
                                    vol.Statut = StatutVol.Annulé;
                                    break;
                                case "PAR":
                                    vol.Statut = StatutVol.Parti;
                                    break;
                                case "NORM":
                                    vol.Statut = StatutVol.Normal;
                                    break;
                                case "SUP":
                                    vol.Statut = StatutVol.Supprimé;
                                    break;
                                default:
                                    vol.Statut = StatutVol.Normal;
                                    break;
                            }
                            vol.TypeAvion = sdr.GetString(sdr.GetOrdinal("TypeAvion"));
                            vol.Immatriculation = sdr.GetString(sdr.GetOrdinal("Immatriculation"));
                            vol.Parking = sdr.GetString(sdr.GetOrdinal("Parking"));
                            vol.DernierHoraire = sdr.GetDateTime(sdr.GetOrdinal("DernierHoraire"));
                            vol.OrigineCreation = sdr.GetString(sdr.GetOrdinal("OrigineCreation"));
                            
                            res.Add(vol);
                        }
                    }
                }
                catch(Exception e)
                {
                }
            }
            return res;

        }
        
      

        public override Vol GetDetailsVol(int idVol)
        {
            //obtenir les details d'un vol

            throw new NotImplementedException();
        }

        public override void AddVol(Vol vol)
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
