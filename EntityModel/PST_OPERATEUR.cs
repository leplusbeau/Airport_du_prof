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
    
    public partial class PST_OPERATEUR
    {
        public PST_OPERATEUR()
        {
            this.CRE_IND = new HashSet<CRE_IND>();
        }
    
        public int ID_RES { get; set; }
        public int ID_GRP_TRI { get; set; }
        public string TRONC_ASSOCIE { get; set; }
        public string TYP_PST { get; set; }
        public string NOM_RES { get; set; }
        public string LIB { get; set; }
    
        public virtual ICollection<CRE_IND> CRE_IND { get; set; }
        public virtual GRP_TRI GRP_TRI { get; set; }
        public virtual PIM PIM { get; set; }
        public virtual BANQUE PST_BNQ_ENRGT { get; set; }
        public virtual LIG_ENT_TRI LIG_ENT_TRI { get; set; }
    }
}
