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
    
    public partial class VOL_DEPART
    {
        public int ID_VOL { get; set; }
        public Nullable<int> ID_EMPORT { get; set; }
        public string SHA { get; set; }
        public string CRE { get; set; }
        public string TYP { get; set; }
        public Nullable<short> JUR { get; set; }
        public Nullable<System.DateTime> SCT { get; set; }
        public Nullable<System.DateTime> AVC { get; set; }
        public string IMM { get; set; }
        public Nullable<short> PAX { get; set; }
        public string MAS { get; set; }
        public string DES { get; set; }
        public Nullable<bool> SHA_EST_FORCE { get; set; }
    
        public virtual EMPORT_VOLS EMPORT_VOLS { get; set; }
        public virtual VOL VOL { get; set; }
    }
}