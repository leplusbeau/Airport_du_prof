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
    
    public partial class ITI
    {
        public int ID_VOL { get; set; }
        public string CODE_VILLE { get; set; }
        public short ORDRE_ESCALE { get; set; }
    
        public virtual VOL VOL { get; set; }
    }
}
