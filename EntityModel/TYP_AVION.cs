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
    
    public partial class TYP_AVION
    {
        public int ID_TYP_AVION { get; set; }
        public string TYP { get; set; }
        public string LIB { get; set; }
        public Nullable<int> PAX_STD { get; set; }
        public Nullable<short> PAX_MAX { get; set; }
        public string OBS { get; set; }
    }
}