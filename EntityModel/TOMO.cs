//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TOMO
    {
        public TOMO()
        {
            this.CRE_IND = new HashSet<CRE_IND>();
        }
    
        public int ID_RES { get; set; }
        public int ID_GRP_TRI { get; set; }
        public float TAUX_CHARGE { get; set; }
        public int NB_BAG_MAX { get; set; }
        public int NB_BAG_TYPIQUE { get; set; }
        public string NOM_RES { get; set; }
        public string LIB { get; set; }
    
        public virtual ICollection<CRE_IND> CRE_IND { get; set; }
        public virtual GRP_TRI GRP_TRI { get; set; }
    }
}
