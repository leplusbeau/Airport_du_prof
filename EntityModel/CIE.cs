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
    
    public partial class CIE
    {
        public CIE()
        {
            this.CLASSE_CIE = new HashSet<CLASSE_CIE>();
            this.EMPORT_VOLS = new HashSet<EMPORT_VOLS>();
            this.EMPORT_VOLS1 = new HashSet<EMPORT_VOLS>();
        }
    
        public int ID_CIE { get; set; }
        public int ID_DCS { get; set; }
        public string CODE_CIE { get; set; }
        public string NO_CIE { get; set; }
        public string CODE_OACI { get; set; }
        public string NOM_CIE { get; set; }
        public bool EST_DISP_IFBS { get; set; }
        public bool EST_FORCE_IFBS { get; set; }
        public string OBS { get; set; }
        public Nullable<System.DateTime> DATE_EST_OBSOLETE { get; set; }
    
        public virtual ICollection<CLASSE_CIE> CLASSE_CIE { get; set; }
        public virtual ICollection<EMPORT_VOLS> EMPORT_VOLS { get; set; }
        public virtual ICollection<EMPORT_VOLS> EMPORT_VOLS1 { get; set; }
    }
}
