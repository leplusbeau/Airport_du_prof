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
    
    public partial class BSM
    {
        public BSM()
        {
            this.BSM_VOL_APPORT = new HashSet<BSM_VOL_APPORT>();
            this.BSM_VOL_CNT = new HashSet<BSM_VOL_CNT>();
            this.OCCURENCE_BAGAGE = new HashSet<OCCURENCE_BAGAGE>();
            this.PART_BSM = new HashSet<PART_BSM>();
        }
    
        public int ID_BSM { get; set; }
        public Nullable<int> ID_VOL { get; set; }
        public string CODE_IATA { get; set; }
        public string CRE { get; set; }
        public System.DateTime DAT_CRE { get; set; }
        public Nullable<bool> MOD { get; set; }
        public Nullable<System.DateTime> DAT_MOD { get; set; }
        public Nullable<bool> SUP { get; set; }
        public Nullable<System.DateTime> DAT_SUP { get; set; }
        public Nullable<System.DateTime> DAT_RECOLLAGE { get; set; }
        public Nullable<bool> DUP { get; set; }
        public string STATUT_BSM { get; set; }
        public string CCLA { get; set; }
        public Nullable<bool> CLA { get; set; }
        public string STA { get; set; }
        public string TYP { get; set; }
        public string VER { get; set; }
        public string NSUR { get; set; }
        public string SSUR { get; set; }
        public Nullable<bool> ISUR { get; set; }
        public string TSUR { get; set; }
        public string GSUR { get; set; }
        public string CSUR { get; set; }
        public string AER_DES { get; set; }
        public string ITI { get; set; }
        public Nullable<bool> EMB { get; set; }
        public Nullable<bool> CHGVOL { get; set; }
        public Nullable<bool> RECOL { get; set; }
        public string CIEE { get; set; }
        public string LIGE { get; set; }
        public short JEXE { get; set; }
        public Nullable<bool> REINTRO { get; set; }
        public Nullable<bool> REAPPARU { get; set; }
        public Nullable<int> NB_PERTE_SUIVI { get; set; }
        public Nullable<System.DateTime> T_PREMIERE_IDENT { get; set; }
        public Nullable<int> API_PREMIERE_IDENT { get; set; }
        public Nullable<int> STATUT_PREMIERE_IDENT { get; set; }
        public string FID { get; set; }
        public string CNT { get; set; }
        public string STATUT_EJECTION { get; set; }
        public Nullable<int> STATUT_TEMPOREL { get; set; }
        public string SSURC { get; set; }
        public string DCS_EMETTEUR { get; set; }
        public bool EST_FORCE_OSS { get; set; }
        public Nullable<bool> EXT { get; set; }
        public string NOM_PASSAGER { get; set; }
    
        public virtual VOL VOL { get; set; }
        public virtual ICollection<BSM_VOL_APPORT> BSM_VOL_APPORT { get; set; }
        public virtual ICollection<BSM_VOL_CNT> BSM_VOL_CNT { get; set; }
        public virtual ICollection<OCCURENCE_BAGAGE> OCCURENCE_BAGAGE { get; set; }
        public virtual ICollection<PART_BSM> PART_BSM { get; set; }
    }
}