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
    
    public partial class TAC_GRP_BAGS
    {
        public int ID_TACHE { get; set; }
        public int ID_EMPORT { get; set; }
        public Nullable<int> ID_MOD_SATISFACT { get; set; }
        public Nullable<System.DateTime> TPLANIF_MODIF { get; set; }
        public Nullable<int> ID_RES { get; set; }
        public string STATUT_TEMPOREL { get; set; }
        public Nullable<short> NB_BAGS { get; set; }
        public System.DateTime TDEB { get; set; }
        public System.DateTime TFIN { get; set; }
        public bool EST_AFFECTEE { get; set; }
        public bool EST_VERROU { get; set; }
        public string NIV_ALA { get; set; }
        public Nullable<short> COD_ALA { get; set; }
        public bool EST_UNE_DUP { get; set; }
        public string CAR_CLASS { get; set; }
        public Nullable<int> ID_TACHE_MERE { get; set; }
        public Nullable<int> COUT_BASE { get; set; }
        public Nullable<int> NB_BAGS_EN_COURS { get; set; }
        public Nullable<int> NB_CONTAINERS { get; set; }
    
        public virtual EMPORT_VOLS EMPORT_VOLS { get; set; }
        public virtual SORTIE_TRI SORTIE_TRI { get; set; }
    }
}
