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
    
    public partial class EMPORT_VOLS
    {
        public EMPORT_VOLS()
        {
            this.EMPORT_ENRGT_SUR = new HashSet<EMPORT_ENRGT_SUR>();
            this.ITI_EMPORT_VOLS = new HashSet<ITI_EMPORT_VOLS>();
            this.TAC_GRP_BAGS = new HashSet<TAC_GRP_BAGS>();
            this.VOL_DEPART = new HashSet<VOL_DEPART>();
        }
    
        public int ID_EMPORT { get; set; }
        public Nullable<int> ID_COURBE_PRES { get; set; }
        public Nullable<int> ID_MOD_CHR { get; set; }
        public Nullable<int> ID_RES { get; set; }
        public string STATUT_EMP { get; set; }
        public Nullable<bool> ANT_GRP_INDEPENDANT { get; set; }
        public Nullable<bool> DM_GRP_INDEPENDANT { get; set; }
        public Nullable<bool> RAT_GRP_INDEPENDANT { get; set; }
        public Nullable<short> NB_BAG_CALCULE { get; set; }
        public Nullable<bool> MOD_CLA_SONT_FORCES { get; set; }
        public Nullable<bool> MOD_CHR_EST_FORCE { get; set; }
        public Nullable<bool> SLA_EST_FORCE { get; set; }
        public Nullable<System.DateTime> TANT { get; set; }
        public Nullable<System.DateTime> TOUVTRI { get; set; }
        public Nullable<System.DateTime> TFTRI { get; set; }
        public Nullable<System.DateTime> TFDM { get; set; }
        public Nullable<System.DateTime> TRATES { get; set; }
        public Nullable<bool> PKG_EST_FORCE { get; set; }
        public Nullable<bool> CEC_EST_FORCE { get; set; }
        public Nullable<bool> CIE_EST_FORCE { get; set; }
        public Nullable<bool> DHC_EST_FORCE { get; set; }
        public Nullable<bool> ITI_EST_FORCE { get; set; }
        public Nullable<bool> JEX_EST_FORCE { get; set; }
        public Nullable<bool> LIG_EST_FORCE { get; set; }
        public Nullable<bool> QRF_EST_FORCE { get; set; }
        public Nullable<bool> DOA_EST_FORCE { get; set; }
        public Nullable<bool> STA_EST_FORCE { get; set; }
        public Nullable<bool> SPK_EST_FORCE { get; set; }
        public Nullable<bool> IMM_EST_FORCE { get; set; }
        public Nullable<bool> PAX_EST_FORCE { get; set; }
        public Nullable<bool> SCT_EST_FORCE { get; set; }
        public Nullable<bool> TYP_EST_FORCE { get; set; }
        public Nullable<bool> CBQ_EST_FORCE { get; set; }
        public int ID_CIE { get; set; }
        public Nullable<int> ID_CEC { get; set; }
        public string LIG { get; set; }
        public short JEX { get; set; }
        public short QRF { get; set; }
        public string PKG { get; set; }
        public Nullable<System.DateTime> DHC { get; set; }
        public string DOA { get; set; }
        public string SPK { get; set; }
        public string STA { get; set; }
        public Nullable<System.DateTime> SCT { get; set; }
        public string IMM { get; set; }
        public Nullable<short> PAX { get; set; }
        public string TYP { get; set; }
    
        public virtual CIE CIE { get; set; }
        public virtual CIE CIE1 { get; set; }
        public virtual ICollection<EMPORT_ENRGT_SUR> EMPORT_ENRGT_SUR { get; set; }
        public virtual LIG_ENT_TRI LIG_ENT_TRI { get; set; }
        public virtual MOD_CHR MOD_CHR { get; set; }
        public virtual ICollection<ITI_EMPORT_VOLS> ITI_EMPORT_VOLS { get; set; }
        public virtual ICollection<TAC_GRP_BAGS> TAC_GRP_BAGS { get; set; }
        public virtual ICollection<VOL_DEPART> VOL_DEPART { get; set; }
    }
}
