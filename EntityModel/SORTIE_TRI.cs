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
    
    public partial class SORTIE_TRI
    {
        public SORTIE_TRI()
        {
            this.CRE_IND = new HashSet<CRE_IND>();
            this.TAC_GRP_BAGS = new HashSet<TAC_GRP_BAGS>();
            this.TAC_ENTREE_TRI = new HashSet<TAC_ENTREE_TRI>();
            this.TAC_SEC_ROUT = new HashSet<TAC_SEC_ROUT>();
            this.TAC_GLOB = new HashSet<TAC_GLOB>();
        }
    
        public int ID_RES { get; set; }
        public int ID_GRP_TRI { get; set; }
        public string TRIEUR { get; set; }
        public string TYPE_SORTIE { get; set; }
        public short NB_GROUPES_MAX { get; set; }
        public short TPS_PARCOURS_TRIEUR { get; set; }
        public short MAX_DEBIT { get; set; }
        public short NB_MAX_BAG { get; set; }
        public string ID_TVJ1 { get; set; }
        public string ID_TVJ2 { get; set; }
        public Nullable<int> NB_BAGS_EN_COURS { get; set; }
        public string OBS { get; set; }
        public string NOM_RES { get; set; }
        public string LIB { get; set; }
    
        public virtual ICollection<CRE_IND> CRE_IND { get; set; }
        public virtual GRP_TRI GRP_TRI { get; set; }
        public virtual ICollection<TAC_GRP_BAGS> TAC_GRP_BAGS { get; set; }
        public virtual ICollection<TAC_ENTREE_TRI> TAC_ENTREE_TRI { get; set; }
        public virtual ICollection<TAC_SEC_ROUT> TAC_SEC_ROUT { get; set; }
        public virtual ICollection<TAC_GLOB> TAC_GLOB { get; set; }
    }
}
