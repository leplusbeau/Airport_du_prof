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
    
    public partial class PORTIQUE
    {
        public int ID_PORTIQUE_SCANNER { get; set; }
        public int ID_GRP_BNQ { get; set; }
        public byte TPS_PARCOURS_GRP_BNQ { get; set; }
    
        public virtual GRP_BNQ GRP_BNQ { get; set; }
    }
}
