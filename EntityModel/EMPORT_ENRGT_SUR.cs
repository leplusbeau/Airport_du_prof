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
    
    public partial class EMPORT_ENRGT_SUR
    {
        public int ID_EMPORT { get; set; }
        public int ID_RES { get; set; }
        public Nullable<System.DateTime> DBQ { get; set; }
        public Nullable<System.DateTime> FBQ { get; set; }
        public string SBQ { get; set; }
    
        public virtual EMPORT_VOLS EMPORT_VOLS { get; set; }
        public virtual BANQUE PST_BNQ_ENRGT { get; set; }
    }
}
