﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CDG1ArchivageEntities : DbContext
    {
        public CDG1ArchivageEntities()
            : base("name=CDG1ArchivageEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AER> AERs { get; set; }
        public DbSet<BSM> BSMs { get; set; }
        public DbSet<BSM_VOL_APPORT> BSM_VOL_APPORT { get; set; }
        public DbSet<BSM_VOL_CNT> BSM_VOL_CNT { get; set; }
        public DbSet<CIE> CIEs { get; set; }
        public DbSet<CLASSE_CIE> CLASSE_CIE { get; set; }
        public DbSet<CODE_ALARME> CODE_ALARME { get; set; }
        public DbSet<CRE_IND> CRE_IND { get; set; }
        public DbSet<EDS> EDS { get; set; }
        public DbSet<EMPORT_ENRGT_SUR> EMPORT_ENRGT_SUR { get; set; }
        public DbSet<EMPORT_VOLS> EMPORT_VOLS { get; set; }
        public DbSet<GRP_BNQ> GRP_BNQ { get; set; }
        public DbSet<GRP_TRI> GRP_TRI { get; set; }
        public DbSet<ITI> ITIs { get; set; }
        public DbSet<ITI_EMPORT_VOLS> ITI_EMPORT_VOLS { get; set; }
        public DbSet<LIG_ENT_TRI> LIG_ENT_TRI { get; set; }
        public DbSet<MOD_CHR> MOD_CHR { get; set; }
        public DbSet<OCCURENCE_BAGAGE> OCCURENCE_BAGAGE { get; set; }
        public DbSet<PARK_AVION> PARK_AVION { get; set; }
        public DbSet<PART_BSM> PART_BSM { get; set; }
        public DbSet<PIM> PIMs { get; set; }
        public DbSet<PORTIQUE> PORTIQUE_SCANNER { get; set; }
        public DbSet<BANQUE> PST_BNQ_ENRGT { get; set; }
        public DbSet<PST_OPERATEUR> PST_OPERATEUR { get; set; }
        public DbSet<SORTIE_TRI> SORTIE_TRI { get; set; }
        public DbSet<TAC_ENTREE_TRI> TAC_ENTREE_TRI { get; set; }
        public DbSet<TAC_GLOB> TAC_GLOB { get; set; }
        public DbSet<TAC_GRP_BAGS> TAC_GRP_BAGS { get; set; }
        public DbSet<TAC_SEC_ROUT> TAC_SEC_ROUT { get; set; }
        public DbSet<TOMO> TOMOes { get; set; }
        public DbSet<TRACE_BAGAGE> TRACE_BAGAGE { get; set; }
        public DbSet<TRONCON> TRONCONs { get; set; }
        public DbSet<TYP_AVION> TYP_AVION { get; set; }
        public DbSet<VOL> VOLs { get; set; }
        public DbSet<VOL_ARRIVE> VOL_ARRIVE { get; set; }
        public DbSet<VOL_DEPART> VOL_DEPART { get; set; }
    }
}
