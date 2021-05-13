using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RoadInv.DB
{
    public partial class roadinvContext : DbContext
    {
        public roadinvContext()
        {
        }

        public roadinvContext(DbContextOptions<roadinvContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ArnoldCopy> ArnoldCopies { get; set; }
        public virtual DbSet<ArnoldDissolve> ArnoldDissolves { get; set; }
        public virtual DbSet<ArnoldMatch> ArnoldMatches { get; set; }
        public virtual DbSet<ConstaintCounty> ConstaintCounties { get; set; }
        public virtual DbSet<ConstaintCountyDistrict> ConstaintCountyDistricts { get; set; }
        public virtual DbSet<ConstaintDistrict> ConstaintDistricts { get; set; }
        public virtual DbSet<ConstaintUrbanAreaCode> ConstaintUrbanAreaCodes { get; set; }
        public virtual DbSet<ConstraintGeneral> ConstraintGenerals { get; set; }
        public virtual DbSet<ConstraintSectionCode> ConstraintSectionCodes { get; set; }
        public virtual DbSet<ConstraintUrbanAreaCounty> ConstraintUrbanAreaCounties { get; set; }
        public virtual DbSet<DatabaseCopy> DatabaseCopies { get; set; }
        public virtual DbSet<DissolveAphnView> DissolveAphnViews { get; set; }
        public virtual DbSet<DissolveAphnView1> DissolveAphnView1s { get; set; }
        public virtual DbSet<DissolveFuncView> DissolveFuncViews { get; set; }
        public virtual DbSet<DissolveFuncView1> DissolveFuncView1s { get; set; }
        public virtual DbSet<DissolveNhsView> DissolveNhsViews { get; set; }
        public virtual DbSet<DissolveNhsView1> DissolveNhsView1s { get; set; }
        public virtual DbSet<DissolveRouteSignView> DissolveRouteSignViews { get; set; }
        public virtual DbSet<DissolveSpecialSystemsView> DissolveSpecialSystemsViews { get; set; }
        public virtual DbSet<DissolveSpecialSystemsView1> DissolveSpecialSystemsView1s { get; set; }
        public virtual DbSet<ExcludeAphn> ExcludeAphns { get; set; }
        public virtual DbSet<ExcludeAphn1> ExcludeAphn1s { get; set; }
        public virtual DbSet<ExcludeNh> ExcludeNhs { get; set; }
        public virtual DbSet<ExcludeNhs1> ExcludeNhs1s { get; set; }
        public virtual DbSet<ExcludeSpecialSystem> ExcludeSpecialSystems { get; set; }
        public virtual DbSet<ExcludeSpecialSystems1> ExcludeSpecialSystems1s { get; set; }
        public virtual DbSet<Gisexport> Gisexports { get; set; }
        public virtual DbSet<LegacyDatum> LegacyData { get; set; }
        public virtual DbSet<OutmileageA> OutmileageAs { get; set; }
        public virtual DbSet<OutmileageAMappable> OutmileageAMappables { get; set; }
        public virtual DbSet<OutmileageAb> OutmileageAbs { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<QcBreak> QcBreaks { get; set; }
        public virtual DbSet<QcGap> QcGaps { get; set; }
        public virtual DbSet<QcOverlap> QcOverlaps { get; set; }
        public virtual DbSet<RoadInv> RoadInvs { get; set; }
        public virtual DbSet<RoadInvDissolve> RoadInvDissolves { get; set; }
        public virtual DbSet<RoadInvWarehouse> RoadInvWarehouses { get; set; }
        public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=INVSQL-DEV;Database=roadinv;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ArnoldCopy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ARNOLD_copy");

                entity.Property(e => e.A1Drpr)
                    .HasMaxLength(2)
                    .HasColumnName("A1_DRPR");

                entity.Property(e => e.A1Drsf)
                    .HasMaxLength(2)
                    .HasColumnName("A1_DRSF");

                entity.Property(e => e.A1Lfadd)
                    .HasMaxLength(10)
                    .HasColumnName("A1_LFADD");

                entity.Property(e => e.A1Ltadd)
                    .HasMaxLength(10)
                    .HasColumnName("A1_LTADD");

                entity.Property(e => e.A1Rfadd)
                    .HasMaxLength(10)
                    .HasColumnName("A1_RFADD");

                entity.Property(e => e.A1Rtadd)
                    .HasMaxLength(10)
                    .HasColumnName("A1_RTADD");

                entity.Property(e => e.A1Str)
                    .HasMaxLength(72)
                    .HasColumnName("A1_STR");

                entity.Property(e => e.A1Styp)
                    .HasMaxLength(4)
                    .HasColumnName("A1_STYP");

                entity.Property(e => e.A2Drpr)
                    .HasMaxLength(2)
                    .HasColumnName("A2_DRPR");

                entity.Property(e => e.A2Drsf)
                    .HasMaxLength(2)
                    .HasColumnName("A2_DRSF");

                entity.Property(e => e.A2Lfadd)
                    .HasMaxLength(10)
                    .HasColumnName("A2_LFADD");

                entity.Property(e => e.A2Ltadd)
                    .HasMaxLength(10)
                    .HasColumnName("A2_LTADD");

                entity.Property(e => e.A2Rfadd)
                    .HasMaxLength(10)
                    .HasColumnName("A2_RFADD");

                entity.Property(e => e.A2Rtadd)
                    .HasMaxLength(10)
                    .HasColumnName("A2_RTADD");

                entity.Property(e => e.A2Str)
                    .HasMaxLength(72)
                    .HasColumnName("A2_STR");

                entity.Property(e => e.A2Styp)
                    .HasMaxLength(4)
                    .HasColumnName("A2_STYP");

                entity.Property(e => e.A3Drpr)
                    .HasMaxLength(2)
                    .HasColumnName("A3_DRPR");

                entity.Property(e => e.A3Drsf)
                    .HasMaxLength(2)
                    .HasColumnName("A3_DRSF");

                entity.Property(e => e.A3Lfadd)
                    .HasMaxLength(10)
                    .HasColumnName("A3_LFADD");

                entity.Property(e => e.A3Ltadd)
                    .HasMaxLength(10)
                    .HasColumnName("A3_LTADD");

                entity.Property(e => e.A3Rfadd)
                    .HasMaxLength(10)
                    .HasColumnName("A3_RFADD");

                entity.Property(e => e.A3Rtadd)
                    .HasMaxLength(10)
                    .HasColumnName("A3_RTADD");

                entity.Property(e => e.A3Str)
                    .HasMaxLength(72)
                    .HasColumnName("A3_STR");

                entity.Property(e => e.A3Styp)
                    .HasMaxLength(4)
                    .HasColumnName("A3_STYP");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhCounty)
                    .HasMaxLength(25)
                    .HasColumnName("AH_County");

                entity.Property(e => e.AhDistrict)
                    .HasMaxLength(2)
                    .HasColumnName("AH_District");

                entity.Property(e => e.AhElm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhId)
                    .HasMaxLength(150)
                    .HasColumnName("AH_ID");

                entity.Property(e => e.AhLength)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_Length");

                entity.Property(e => e.AhRevAcf)
                    .HasMaxLength(50)
                    .HasColumnName("AH_Rev_ACF");

                entity.Property(e => e.AhRoadId)
                    .HasMaxLength(150)
                    .HasColumnName("AH_RoadID");

                entity.Property(e => e.AhRoute)
                    .HasMaxLength(100)
                    .HasColumnName("AH_Route");

                entity.Property(e => e.AhSection)
                    .HasMaxLength(3)
                    .HasColumnName("AH_Section");

                entity.Property(e => e.AhSegNum)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_Seg_Num");

                entity.Property(e => e.AhSigned)
                    .HasMaxLength(10)
                    .HasColumnName("AH_Signed");

                entity.Property(e => e.AttrCheck)
                    .HasMaxLength(254)
                    .HasColumnName("Attr_Check");

                entity.Property(e => e.BeginDate).HasColumnName("BEGIN_DATE");

                entity.Property(e => e.CityL)
                    .HasMaxLength(30)
                    .HasColumnName("CITY_L");

                entity.Property(e => e.CityR)
                    .HasMaxLength(30)
                    .HasColumnName("CITY_R");

                entity.Property(e => e.CnLFips)
                    .HasMaxLength(3)
                    .HasColumnName("CN_L_FIPS");

                entity.Property(e => e.CnRFips)
                    .HasMaxLength(3)
                    .HasColumnName("CN_R_FIPS");

                entity.Property(e => e.Comment)
                    .HasMaxLength(254)
                    .HasColumnName("COMMENT_");

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CreatedUser)
                    .HasMaxLength(255)
                    .HasColumnName("created_user");

                entity.Property(e => e.EditDate).HasColumnName("EDIT_DATE");

                entity.Property(e => e.EditDesc)
                    .HasMaxLength(254)
                    .HasColumnName("EDIT_DESC");

                entity.Property(e => e.EditSrc)
                    .HasMaxLength(254)
                    .HasColumnName("EDIT_SRC");

                entity.Property(e => e.EndDate).HasColumnName("END_DATE");

                entity.Property(e => e.GlobalId).HasColumnName("GlobalID");

                entity.Property(e => e.LastEditedDate).HasColumnName("last_edited_date");

                entity.Property(e => e.LastEditedUser)
                    .HasMaxLength(255)
                    .HasColumnName("last_edited_user");

                entity.Property(e => e.LogCheck)
                    .HasMaxLength(254)
                    .HasColumnName("Log_Check");

                entity.Property(e => e.LogDirect)
                    .HasMaxLength(2)
                    .HasColumnName("LOG_DIRECT");

                entity.Property(e => e.MetaId)
                    .HasMaxLength(20)
                    .HasColumnName("META_ID");

                entity.Property(e => e.MetaL)
                    .HasMaxLength(20)
                    .HasColumnName("META_L");

                entity.Property(e => e.MetaR)
                    .HasMaxLength(20)
                    .HasColumnName("META_R");

                entity.Property(e => e.MonoCheck)
                    .HasMaxLength(254)
                    .HasColumnName("Mono_Check");

                entity.Property(e => e.Nssda)
                    .HasMaxLength(4)
                    .HasColumnName("NSSDA");

                entity.Property(e => e.NssdaSrc)
                    .HasMaxLength(20)
                    .HasColumnName("NSSDA_SRC");

                entity.Property(e => e.NssdaVal)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("NSSDA_VAL");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.PlAddF)
                    .HasMaxLength(10)
                    .HasColumnName("PL_ADD_F");

                entity.Property(e => e.PlAddT)
                    .HasMaxLength(10)
                    .HasColumnName("PL_ADD_T");

                entity.Property(e => e.PrAddF)
                    .HasMaxLength(10)
                    .HasColumnName("PR_ADD_F");

                entity.Property(e => e.PrAddT)
                    .HasMaxLength(10)
                    .HasColumnName("PR_ADD_T");

                entity.Property(e => e.PreDir)
                    .HasMaxLength(2)
                    .HasColumnName("PRE_DIR");

                entity.Property(e => e.PstrNam)
                    .HasMaxLength(72)
                    .HasColumnName("PSTR_NAM");

                entity.Property(e => e.PstrType)
                    .HasMaxLength(4)
                    .HasColumnName("PSTR_TYPE");

                entity.Property(e => e.PsufDir)
                    .HasMaxLength(2)
                    .HasColumnName("PSUF_DIR");

                entity.Property(e => e.RdClass)
                    .HasMaxLength(25)
                    .HasColumnName("RD_CLASS");

                entity.Property(e => e.RdDesign)
                    .HasMaxLength(25)
                    .HasColumnName("RD_DESIGN");

                entity.Property(e => e.RdSurftyp)
                    .HasMaxLength(25)
                    .HasColumnName("RD_SURFTYP");

                entity.Property(e => e.SdeStateId).HasColumnName("SDE_STATE_ID");

                entity.Property(e => e.SrcCode)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("SRC_CODE");

                entity.Property(e => e.SrcDesc)
                    .HasMaxLength(254)
                    .HasColumnName("SRC_DESC");

                entity.Property(e => e.StateL)
                    .HasMaxLength(2)
                    .HasColumnName("STATE_L");

                entity.Property(e => e.StateR)
                    .HasMaxLength(2)
                    .HasColumnName("STATE_R");

                entity.Property(e => e.SysStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Sys_Status");

                entity.Property(e => e.UniqueId)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("UNIQUE_ID");

                entity.Property(e => e.Zip4L)
                    .HasMaxLength(4)
                    .HasColumnName("ZIP4_L");

                entity.Property(e => e.Zip4R)
                    .HasMaxLength(4)
                    .HasColumnName("ZIP4_R");

                entity.Property(e => e.Zip5L)
                    .HasMaxLength(5)
                    .HasColumnName("ZIP5_L");

                entity.Property(e => e.Zip5R)
                    .HasMaxLength(5)
                    .HasColumnName("ZIP5_R");
            });

            modelBuilder.Entity<ArnoldDissolve>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ARNOLD_Dissolve");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhElm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");
            });

            modelBuilder.Entity<ArnoldMatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ARNOLD_Match");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhElm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");

                entity.Property(e => e.ErrorFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("errorFlag");
            });

            modelBuilder.Entity<ConstaintCounty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Constaint_County");

                entity.Property(e => e.County)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CountyNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FhwaNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fhwaNumber");
            });

            modelBuilder.Entity<ConstaintCountyDistrict>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Constaint_CountyDistrict");

                entity.Property(e => e.CountyNumber)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictNumber)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ConstaintDistrict>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Constaint_District");

                entity.Property(e => e.DistrictNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(59)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConstaintUrbanAreaCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Constaint_UrbanAreaCode");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UrbanCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConstraintGeneral>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Constraint_General");

                entity.Property(e => e.DomainName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("domainName");

                entity.Property(e => e.Domainvalue)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("domainvalue");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Label)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("label");

                entity.Property(e => e.ValueDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("valueDescription");
            });

            modelBuilder.Entity<ConstraintSectionCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Constraint_SectionCode");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConstraintUrbanAreaCounty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Constraint_UrbanAreaCounty");

                entity.Property(e => e.CountyNumber)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UrbanCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DatabaseCopy>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DissolveAphnView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DissolveAPHN_View");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhElm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");

                entity.Property(e => e.Aphn)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("APHN");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<DissolveAphnView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DissolveAPHN_View_1");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhCounty)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AH_County");

                entity.Property(e => e.AhDirection)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AH_Direction");

                entity.Property(e => e.AhElm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");

                entity.Property(e => e.AhSection)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AH_Section");

                entity.Property(e => e.Aphn)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("APHN");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<DissolveFuncView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DissolveFunc_View");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhElm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");

                entity.Property(e => e.Aphn)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("APHN");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<DissolveFuncView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DissolveFunc_View_1");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhCounty)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AH_County");

                entity.Property(e => e.AhDirection)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AH_Direction");

                entity.Property(e => e.AhElm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");

                entity.Property(e => e.AhSection)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AH_Section");

                entity.Property(e => e.Aphn)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("APHN");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<DissolveNhsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DissolveNHS_View");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhElm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NhsSummary)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NHS_Summary");
            });

            modelBuilder.Entity<DissolveNhsView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DissolveNHS_View_1");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhCounty)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AH_County");

                entity.Property(e => e.AhDirection)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AH_Direction");

                entity.Property(e => e.AhElm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");

                entity.Property(e => e.AhSection)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AH_Section");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NhsSummary)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NHS_Summary");
            });

            modelBuilder.Entity<DissolveRouteSignView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DissolveRouteSign_View");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhElm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RouteSign)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DissolveSpecialSystemsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DissolveSpecialSystems_View");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhElm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SpecialSystems)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DissolveSpecialSystemsView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DissolveSpecialSystems_View_1");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhCounty)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AH_County");

                entity.Property(e => e.AhDirection)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AH_Direction");

                entity.Property(e => e.AhElm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");

                entity.Property(e => e.AhSection)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AH_Section");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SpecialSystems)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExcludeAphn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("excludeAPHN");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhElm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .IsRequired()
                    .HasMaxLength(273)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");
            });

            modelBuilder.Entity<ExcludeAphn1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("excludeAPHN_1");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhCounty)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AH_County");

                entity.Property(e => e.AhElm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .IsRequired()
                    .HasMaxLength(273)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");

                entity.Property(e => e.AhSection)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AH_Section");

                entity.Property(e => e.Aphn)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("APHN");

                entity.Property(e => e.LogDirect)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOG_DIRECT");
            });

            modelBuilder.Entity<ExcludeNh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("excludeNHS");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhElm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .IsRequired()
                    .HasMaxLength(273)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");
            });

            modelBuilder.Entity<ExcludeNhs1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("excludeNHS_1");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhCounty)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AH_County");

                entity.Property(e => e.AhElm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .IsRequired()
                    .HasMaxLength(273)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");

                entity.Property(e => e.AhSection)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AH_Section");

                entity.Property(e => e.LogDirect)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOG_DIRECT");

                entity.Property(e => e.Nhs)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("NHS");
            });

            modelBuilder.Entity<ExcludeSpecialSystem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("excludeSpecialSystems");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhElm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .IsRequired()
                    .HasMaxLength(273)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");
            });

            modelBuilder.Entity<ExcludeSpecialSystems1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("excludeSpecialSystems_1");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhCounty)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AH_County");

                entity.Property(e => e.AhElm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .IsRequired()
                    .HasMaxLength(273)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");

                entity.Property(e => e.AhSection)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AH_Section");

                entity.Property(e => e.LogDirect)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOG_DIRECT");

                entity.Property(e => e.SpecialSystems)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gisexport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GISExport");

                entity.Property(e => e.Adt).HasColumnName("ADT");

                entity.Property(e => e.AdtYear).HasColumnName("ADT_Year");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhCounty)
                    .HasMaxLength(25)
                    .HasColumnName("AH_County");

                entity.Property(e => e.AhDistrict)
                    .HasMaxLength(2)
                    .HasColumnName("AH_District");

                entity.Property(e => e.AhElm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhLength)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_Length");

                entity.Property(e => e.AhRoadId)
                    .HasMaxLength(150)
                    .HasColumnName("AH_RoadID");

                entity.Property(e => e.AhRoute)
                    .HasMaxLength(100)
                    .HasColumnName("AH_Route");

                entity.Property(e => e.AhSection)
                    .HasMaxLength(3)
                    .HasColumnName("AH_Section");

                entity.Property(e => e.Aphn).HasColumnName("APHN");

                entity.Property(e => e.ArnoldConv)
                    .HasMaxLength(1)
                    .HasColumnName("ARNOLD_CONV");

                entity.Property(e => e.AtGradeOther).HasColumnName("At_Grade_Other");

                entity.Property(e => e.BaseThickness).HasColumnName("Base_Thickness");

                entity.Property(e => e.BaseType).HasColumnName("Base_Type");

                entity.Property(e => e.Comment).HasMaxLength(150);

                entity.Property(e => e.CounterPeakLanes).HasColumnName("Counter_Peak_Lanes");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CreatedUser)
                    .HasMaxLength(255)
                    .HasColumnName("created_user");

                entity.Property(e => e.CrewNumber).HasMaxLength(5);

                entity.Property(e => e.GlobalId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("GlobalID");

                entity.Property(e => e.HovLanes).HasColumnName("HOV_Lanes");

                entity.Property(e => e.HovType).HasColumnName("HOV_Type");

                entity.Property(e => e.HpmsSection).HasColumnName("HPMS_Section");

                entity.Property(e => e.IsStructure).HasColumnName("IS_Structure");

                entity.Property(e => e.LastEditedDate).HasColumnName("last_edited_date");

                entity.Property(e => e.LastEditedUser)
                    .HasMaxLength(255)
                    .HasColumnName("last_edited_user");

                entity.Property(e => e.LastOverlayThickness)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("Last_Overlay_Thickness");

                entity.Property(e => e.LegacyEndLogmile).HasColumnType("numeric(38, 8)");

                entity.Property(e => e.LegacyLogMile).HasColumnType("numeric(38, 8)");

                entity.Property(e => e.LocError)
                    .HasMaxLength(50)
                    .HasColumnName("LOC_ERROR");

                entity.Property(e => e.LogDirection)
                    .HasMaxLength(1)
                    .HasColumnName("LOG_DIRECTION");

                entity.Property(e => e.MedianWidth1).HasColumnName("Median_Width");

                entity.Property(e => e.Nhs).HasColumnName("NHS");

                entity.Property(e => e.NhsSummary).HasColumnName("NHS_Summary");

                entity.Property(e => e.NumberSignals).HasColumnName("Number_Signals");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.PctGreenTime).HasColumnName("Pct_Green_Time");

                entity.Property(e => e.PctPassSight).HasColumnName("Pct_Pass_Sight");

                entity.Property(e => e.PeakLanes).HasColumnName("Peak_Lanes");

                entity.Property(e => e.PeakParking).HasColumnName("Peak_Parking");

                entity.Property(e => e.Psr)
                    .HasMaxLength(5)
                    .HasColumnName("PSR");

                entity.Property(e => e.RdClass)
                    .HasMaxLength(25)
                    .HasColumnName("RD_CLASS");

                entity.Property(e => e.RdDesign)
                    .HasMaxLength(25)
                    .HasColumnName("RD_DESIGN");

                entity.Property(e => e.RdSurftyp)
                    .HasMaxLength(25)
                    .HasColumnName("RD_SURFTYP");

                entity.Property(e => e.RoadId)
                    .HasMaxLength(15)
                    .HasColumnName("RoadID");

                entity.Property(e => e.RoughCode).HasMaxLength(50);

                entity.Property(e => e.SampleId)
                    .HasMaxLength(15)
                    .HasColumnName("SampleID");

                entity.Property(e => e.ShapeStlength)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("Shape_STLength__");

                entity.Property(e => e.SignalType).HasColumnName("Signal_Type");

                entity.Property(e => e.StopSigns).HasColumnName("Stop_Signs");

                entity.Property(e => e.Temp)
                    .HasMaxLength(255)
                    .HasColumnName("temp");

                entity.Property(e => e.Terrain).HasMaxLength(1);

                entity.Property(e => e.ThicknessFlexible)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("Thickness_Flexible");

                entity.Property(e => e.ThicknessRigid)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("Thickness_Rigid");

                entity.Property(e => e.TollCharged).HasColumnName("Toll_Charged");

                entity.Property(e => e.TotalLanes).HasColumnName("Total_Lanes");

                entity.Property(e => e.TravelLanes).HasColumnName("Travel_Lanes");

                entity.Property(e => e.TurnLanesL).HasColumnName("Turn_Lanes_L");

                entity.Property(e => e.TurnLanesR).HasColumnName("Turn_Lanes_R");

                entity.Property(e => e.UniqueId).HasColumnName("UniqueID");

                entity.Property(e => e.UrbanAreaCode).HasMaxLength(10);

                entity.Property(e => e.WideningObstacle)
                    .HasMaxLength(5)
                    .HasColumnName("Widening_Obstacle");

                entity.Property(e => e.WideningPotential).HasColumnName("Widening_Potential");

                entity.Property(e => e.YearBuilt).HasMaxLength(50);

                entity.Property(e => e.YearIri)
                    .HasMaxLength(50)
                    .HasColumnName("YearIRI");

                entity.Property(e => e.YearLastConstruction)
                    .HasMaxLength(5)
                    .HasColumnName("Year_Last_Construction");

                entity.Property(e => e.YearRecon).HasMaxLength(50);
            });

            modelBuilder.Entity<LegacyDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Access)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AhBlm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhCounty)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AH_County");

                entity.Property(e => e.AhDistrict).HasColumnName("AH_District");

                entity.Property(e => e.AhElm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoute)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AH_Route");

                entity.Property(e => e.AhSection)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AH_Section");

                entity.Property(e => e.AlternativeRouteName)
                    .HasMaxLength(1)
                    .HasColumnName("Alternative_Route_Name");

                entity.Property(e => e.Aphn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("APHN");

                entity.Property(e => e.Comment1).HasMaxLength(100);

                entity.Property(e => e.ExtraLanes)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FuncClass)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GovermentCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LeftShoulderSurface)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LeftShoulderWidth)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LogDirect)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LOG_DIRECT");

                entity.Property(e => e.MedianType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MedianWidth)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nhs)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NHS");

                entity.Property(e => e.OneDirectionNumLanes)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RightShoulderSurface)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RightShoulderWidth)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RouteSign)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RuralUrbanArea)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SpecialSystem)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SurfaceType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SystemStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TypeOperation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TypeRoad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UrbanAreaCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.YearBuilt).HasMaxLength(50);

                entity.Property(e => e.YearRecon).HasMaxLength(50);
            });

            modelBuilder.Entity<OutmileageA>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OUTMILEAGE_A");

                entity.Property(e => e.Access)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AhBlm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhCounty)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AH_County");

                entity.Property(e => e.AhDistrict)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("AH_District");

                entity.Property(e => e.AhElm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhLength)
                    .HasColumnType("decimal(19, 3)")
                    .HasColumnName("AH_Length");

                entity.Property(e => e.AhRoute)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("AH_Route");

                entity.Property(e => e.AhSection)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AH_Section");

                entity.Property(e => e.AlternativeRouteName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Alternative_Route_Name");

                entity.Property(e => e.Aphn)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("APHN");

                entity.Property(e => e.Comment1)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraLanes)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FuncClass)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Gisid).HasColumnName("GISID");

                entity.Property(e => e.GovermentCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LeftShoulderSurface)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LogDirect)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOG_DIRECT");

                entity.Property(e => e.MedianType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MedianWidth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Nhs)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("NHS");

                entity.Property(e => e.NumberLanes)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RightShoulderSurface)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RouteSign)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RuralUrbanArea)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SectionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialSystems)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SurfaceType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SystemStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOperation)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TypeRoad)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UrbanAreaCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YearBuilt)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.YearRecon)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OutmileageAMappable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OUTMILEAGE_A_Mappable");

                entity.Property(e => e.Access)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AhBlm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhCounty)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AH_County");

                entity.Property(e => e.AhDistrict)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("AH_District");

                entity.Property(e => e.AhElm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhLength)
                    .HasColumnType("decimal(19, 3)")
                    .HasColumnName("AH_Length");

                entity.Property(e => e.AhRoute)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("AH_Route");

                entity.Property(e => e.AhSection)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AH_Section");

                entity.Property(e => e.AlternativeRouteName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Alternative_Route_Name");

                entity.Property(e => e.Aphn)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("APHN");

                entity.Property(e => e.Comment1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraLanes)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FuncClass)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Gisid).HasColumnName("GISID");

                entity.Property(e => e.GovermentCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LeftShoulderSurface)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LogDirect)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOG_DIRECT");

                entity.Property(e => e.MedianType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MedianWidth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Nhs)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("NHS");

                entity.Property(e => e.NumberLanes)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RightShoulderSurface)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RouteSign)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RuralUrbanArea)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SectionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialSystems)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SurfaceType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SystemStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOperation)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TypeRoad)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UrbanAreaCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YearBuilt)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.YearRecon)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OutmileageAb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OUTMILEAGE_AB");

                entity.Property(e => e.Access)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AhBlm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhCounty)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AH_County");

                entity.Property(e => e.AhDistrict)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("AH_District");

                entity.Property(e => e.AhElm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhLength)
                    .HasColumnType("decimal(19, 3)")
                    .HasColumnName("AH_Length");

                entity.Property(e => e.AhRoute)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("AH_Route");

                entity.Property(e => e.AhSection)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AH_Section");

                entity.Property(e => e.AlternativeRouteName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Alternative_Route_Name");

                entity.Property(e => e.Aphn)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("APHN");

                entity.Property(e => e.Comment1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraLanes)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FuncClass)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Gisid).HasColumnName("GISID");

                entity.Property(e => e.GovermentCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LeftShoulderSurface)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LogDirect)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOG_DIRECT");

                entity.Property(e => e.MedianType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MedianWidth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Nhs)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("NHS");

                entity.Property(e => e.NumberLanes)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RightShoulderSurface)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RouteSign)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RuralUrbanArea)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SectionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialSystems)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SurfaceType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SystemStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOperation)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TypeRoad)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UrbanAreaCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YearBuilt)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.YearRecon)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Aphnbulk)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("APHNBulk");

                entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");

                entity.Property(e => e.FuncBulk)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nhsbulk)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NHSBulk");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<QcBreak>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QC_breaks");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhElm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .IsRequired()
                    .HasMaxLength(273)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");
            });

            modelBuilder.Entity<QcGap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QC_gaps");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhElm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");
            });

            modelBuilder.Entity<QcOverlap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QC_overlap");

                entity.Property(e => e.AhRoadId1)
                    .IsRequired()
                    .HasMaxLength(273)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID1");

                entity.Property(e => e.OverlapBlm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("overlapBLM");

                entity.Property(e => e.OverlapElm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("overlapELM");
            });

            modelBuilder.Entity<RoadInv>(entity =>
            {
                entity.ToTable("RoadInv");

                entity.HasIndex(e => e.LogDirect, "LogDirectIndex");

                entity.HasIndex(e => e.AhRoadId, "RoadIDIndex");

                entity.HasIndex(e => e.AhRoute, "RouteIDIndex");

                entity.HasIndex(e => e.AhSection, "SectionIndex");

                entity.HasIndex(e => e.AhCounty, "countyIDIndex");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Access)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AhBlm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhCounty)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AH_County");

                entity.Property(e => e.AhDistrict)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("AH_District");

                entity.Property(e => e.AhElm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhLength)
                    .HasColumnType("decimal(19, 3)")
                    .HasColumnName("AH_Length")
                    .HasComputedColumnSql("([AH_ELM]-[AH_BLM])", false);

                entity.Property(e => e.AhRoadId)
                    .IsRequired()
                    .HasMaxLength(273)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID")
                    .HasComputedColumnSql("(concat([AH_County],'x',[AH_Route],'x',[AH_Section],'x',[LOG_DIRECT]))", false);

                entity.Property(e => e.AhRoute)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("AH_Route");

                entity.Property(e => e.AhSection)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AH_Section");

                entity.Property(e => e.AlternativeRouteName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Alternative_Route_Name");

                entity.Property(e => e.Aphn)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("APHN");

                entity.Property(e => e.ArnoldConv)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Arnold_conv");

                entity.Property(e => e.BothDirectionNumLanes)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Comment1)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraLanes)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FuncClass)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.GiscreateDate)
                    .HasColumnType("date")
                    .HasColumnName("GIScreate_date");

                entity.Property(e => e.GiscreatedUser)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("GIScreated_user");

                entity.Property(e => e.Gisid).HasColumnName("GISID");

                entity.Property(e => e.GislastEditedDate)
                    .HasColumnType("date")
                    .HasColumnName("GISLast_edited_date");

                entity.Property(e => e.GislastEditedUser)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("GISLast_edited_user");

                entity.Property(e => e.GovermentCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LeftShoulderSurface)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LegacyBlm)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("LegacyBLM");

                entity.Property(e => e.LegacyElm)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("LegacyELM");

                entity.Property(e => e.LegacyId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LegacyID");

                entity.Property(e => e.LogDirect)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOG_DIRECT");

                entity.Property(e => e.MedianType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MedianWidth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Nhs)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("NHS");

                entity.Property(e => e.OneDirectionNumLanes)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RightShoulderSurface)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RouteSign)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RuralUrbanArea)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialSystems)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SurfaceType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SystemStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOperation)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TypeRoad)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.UrbanAreaCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YearAdt)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("YearADT");

                entity.Property(e => e.YearBuilt)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.YearRecon)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoadInvDissolve>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RoadInv_Dissolve");

                entity.Property(e => e.AhBlm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhElm)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhRoadId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AH_RoadID");
            });

            modelBuilder.Entity<RoadInvWarehouse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RoadInv_warehouse");

                entity.Property(e => e.Access)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AhBlm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_BLM");

                entity.Property(e => e.AhCounty)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AH_County");

                entity.Property(e => e.AhDistrict)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("AH_District");

                entity.Property(e => e.AhElm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("AH_ELM");

                entity.Property(e => e.AhLength)
                    .HasColumnType("decimal(19, 3)")
                    .HasColumnName("AH_Length");

                entity.Property(e => e.AhRoute)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("AH_Route");

                entity.Property(e => e.AhSection)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AH_Section");

                entity.Property(e => e.AlternativeRouteName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Alternative_Route_Name");

                entity.Property(e => e.Aphn)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("APHN");

                entity.Property(e => e.ArnoldConv)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Arnold_conv");

                entity.Property(e => e.BothDirectionNumLanes)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Comment1)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraLanes)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FuncClass)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Gisid).HasColumnName("GISID");

                entity.Property(e => e.GovermentCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LeftShoulderSurface)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LegacyBlm)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("LegacyBLM");

                entity.Property(e => e.LegacyElm)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("LegacyELM");

                entity.Property(e => e.LegacyId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LegacyID");

                entity.Property(e => e.LogDirect)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LOG_DIRECT");

                entity.Property(e => e.MedianType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MedianWidth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modificationDate");

                entity.Property(e => e.ModificationType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("modificationType");

                entity.Property(e => e.ModificationUser)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("modificationUser");

                entity.Property(e => e.Nhs)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("NHS");

                entity.Property(e => e.OneDirectionNumLanes)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RightShoulderSurface)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RouteSign)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RuralUrbanArea)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialSystems)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SurfaceType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SystemStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOperation)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TypeRoad)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UrbanAreaCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YearAdt)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("YearADT");

                entity.Property(e => e.YearBuilt)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.YearRecon)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sysdiagram>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sysdiagrams");

                entity.Property(e => e.Definition).HasColumnName("definition");

                entity.Property(e => e.DiagramId).HasColumnName("diagram_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.PrincipalId).HasColumnName("principal_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
