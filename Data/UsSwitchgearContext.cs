using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Switchgear_TimeTracker.Models;

namespace Switchgear_TimeTracker.Data;

public partial class UsSwitchgearContext : DbContext
{
    public UsSwitchgearContext()
    {
    }

    public UsSwitchgearContext(DbContextOptions<UsSwitchgearContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActualHour> ActualHours { get; set; }

    public virtual DbSet<ExcludeFa> ExcludeFas { get; set; }

    public virtual DbSet<ExcludeMa> ExcludeMas { get; set; }

    public virtual DbSet<LaborValue> LaborValues { get; set; }

    public virtual DbSet<PlannedHoursPerWeek> PlannedHoursPerWeeks { get; set; }

    public virtual DbSet<PlannedHoursPerWeekLinesAdded> PlannedHoursPerWeekLinesAddeds { get; set; }

    public virtual DbSet<ProjectProductStructureTemp> ProjectProductStructureTemps { get; set; }

    public virtual DbSet<SiopActionItemList> SiopActionItemLists { get; set; }

    public virtual DbSet<SwitchgearTest> SwitchgearTests { get; set; }

    public virtual DbSet<TblActivity> TblActivities { get; set; }

    public virtual DbSet<TblAreaReportNewTimestamp> TblAreaReportNewTimestamps { get; set; }

    public virtual DbSet<TblAsignTeam> TblAsignTeams { get; set; }

    public virtual DbSet<TblAssignTeamFa> TblAssignTeamFas { get; set; }

    public virtual DbSet<TblAssignTeamSa> TblAssignTeamSas { get; set; }

    public virtual DbSet<TblChecklistSnaglist> TblChecklistSnaglists { get; set; }

    public virtual DbSet<TblChecklistTransaction> TblChecklistTransactions { get; set; }

    public virtual DbSet<TblChecklistTransactionsDatum> TblChecklistTransactionsData { get; set; }

    public virtual DbSet<TblClock> TblClocks { get; set; }

    public virtual DbSet<TblClockTransaction> TblClockTransactions { get; set; }

    public virtual DbSet<TblDepartment> TblDepartments { get; set; }

    public virtual DbSet<TblEmail> TblEmails { get; set; }

    public virtual DbSet<TblEmployee> TblEmployees { get; set; }

    public virtual DbSet<TblHoliday> TblHolidays { get; set; }

    public virtual DbSet<TblImportClockData1> TblImportClockData1s { get; set; }

    public virtual DbSet<TblInfo> TblInfos { get; set; }

    public virtual DbSet<TblLaborTimeStamp> TblLaborTimeStamps { get; set; }

    public virtual DbSet<TblMisc> TblMiscs { get; set; }

    public virtual DbSet<TblPanelEarlyfinishTemplate> TblPanelEarlyfinishTemplates { get; set; }

    public virtual DbSet<TblPanelSizeTemplate> TblPanelSizeTemplates { get; set; }

    public virtual DbSet<TblPerson> TblPeople { get; set; }

    public virtual DbSet<TblProject> TblProjects { get; set; }

    public virtual DbSet<TblProjectChecklist> TblProjectChecklists { get; set; }

    public virtual DbSet<TblProjectPanelInfo> TblProjectPanelInfos { get; set; }

    public virtual DbSet<TblRemake> TblRemakes { get; set; }

    public virtual DbSet<TblSmdMaterialBorrowTransaction> TblSmdMaterialBorrowTransactions { get; set; }

    public virtual DbSet<TblStoreInfo> TblStoreInfos { get; set; }

    public virtual DbSet<TblStorePicklist> TblStorePicklists { get; set; }

    public virtual DbSet<TblStorePicklistItem> TblStorePicklistItems { get; set; }

    public virtual DbSet<TblStoreTransaction> TblStoreTransactions { get; set; }

    public virtual DbSet<TblSwgAreaReportTimestamp> TblSwgAreaReportTimestamps { get; set; }

    public virtual DbSet<TblSwgAreaReportTimestampList> TblSwgAreaReportTimestampLists { get; set; }

    public virtual DbSet<TblSwgReportArea> TblSwgReportAreas { get; set; }

    public virtual DbSet<TblTaskTemplate> TblTaskTemplates { get; set; }

    public virtual DbSet<TblTeam> TblTeams { get; set; }

    public virtual DbSet<TblTempItemList> TblTempItemLists { get; set; }

    public virtual DbSet<TblTemplateArea> TblTemplateAreas { get; set; }

    public virtual DbSet<TblTemplatePlanningArea> TblTemplatePlanningAreas { get; set; }

    public virtual DbSet<TblTemplatePlanningPanelInfo> TblTemplatePlanningPanelInfos { get; set; }

    public virtual DbSet<TblTemplatePlanningTime> TblTemplatePlanningTimes { get; set; }

    public virtual DbSet<TblTransaction> TblTransactions { get; set; }

    public virtual DbSet<TblTransactionsArea> TblTransactionsAreas { get; set; }

    public virtual DbSet<TblTransactionsPicture> TblTransactionsPictures { get; set; }

    public virtual DbSet<TblUpdateIfsEarlyFinishError> TblUpdateIfsEarlyFinishErrors { get; set; }

    public virtual DbSet<TeamAssignment> TeamAssignments { get; set; }

    public virtual DbSet<Temp> Temps { get; set; }

    public virtual DbSet<TempStorePickListItem> TempStorePickListItems { get; set; }

    public virtual DbSet<TempStorePickListLocation> TempStorePickListLocations { get; set; }

    public virtual DbSet<TempTblProjectPanelInfo> TempTblProjectPanelInfos { get; set; }

    public virtual DbSet<TempTblTemplatePlanningPanelInfo> TempTblTemplatePlanningPanelInfos { get; set; }

    public virtual DbSet<ViewActivityWithTeam> ViewActivityWithTeams { get; set; }

    public virtual DbSet<ViewFaAcbRow> ViewFaAcbRows { get; set; }

    public virtual DbSet<ViewFaCableacce> ViewFaCableacces { get; set; }

    public virtual DbSet<ViewFaCamlock> ViewFaCamlocks { get; set; }

    public virtual DbSet<ViewFaControlDoor> ViewFaControlDoors { get; set; }

    public virtual DbSet<ViewFaFlange> ViewFaFlanges { get; set; }

    public virtual DbSet<ViewFaMccbspd2ndFix> ViewFaMccbspd2ndFixes { get; set; }

    public virtual DbSet<ViewFaTime> ViewFaTimes { get; set; }

    public virtual DbSet<ViewFaTxCopper> ViewFaTxCoppers { get; set; }

    public virtual DbSet<ViewFaWeeklyPlan> ViewFaWeeklyPlans { get; set; }

    public virtual DbSet<ViewFainterlinking> ViewFainterlinkings { get; set; }

    public virtual DbSet<ViewIssue> ViewIssues { get; set; }

    public virtual DbSet<ViewMa> ViewMas { get; set; }

    public virtual DbSet<ViewMasTime> ViewMasTimes { get; set; }

    public virtual DbSet<ViewMasWeeklyPlan> ViewMasWeeklyPlans { get; set; }

    public virtual DbSet<ViewMaterialStatus> ViewMaterialStatuses { get; set; }

    public virtual DbSet<ViewMisc> ViewMiscs { get; set; }

    public virtual DbSet<ViewProductionReportTime> ViewProductionReportTimes { get; set; }

    public virtual DbSet<ViewQryTeamPlanning> ViewQryTeamPlannings { get; set; }

    public virtual DbSet<ViewReportByArea> ViewReportByAreas { get; set; }

    public virtual DbSet<ViewSaDistBd> ViewSaDistBds { get; set; }

    public virtual DbSet<ViewSaMccbspdFitout> ViewSaMccbspdFitouts { get; set; }

    public virtual DbSet<ViewSaTime> ViewSaTimes { get; set; }

    public virtual DbSet<ViewSacamlock> ViewSacamlocks { get; set; }

    public virtual DbSet<ViewSacontrol> ViewSacontrols { get; set; }

    public virtual DbSet<ViewTempTime> ViewTempTimes { get; set; }

    public virtual DbSet<ViewTestAccTime> ViewTestAccTimes { get; set; }

    public virtual DbSet<ViewTestMaxTime> ViewTestMaxTimes { get; set; }

    public virtual DbSet<ViewTotalPanelInfoTime> ViewTotalPanelInfoTimes { get; set; }

    public virtual DbSet<ViewTransactionActivity> ViewTransactionActivities { get; set; }

    public virtual DbSet<ViewTransactionsDistinct> ViewTransactionsDistincts { get; set; }

    public virtual DbSet<ViewUnionArea> ViewUnionAreas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=SCSQL01;Initial Catalog=us_switchgear;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActualHour>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Actual_Hours$PrimaryKey");

            entity.Property(e => e.ActualHours).HasDefaultValue(0m);
        });

        modelBuilder.Entity<LaborValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Labor Value$ID");

            entity.Property(e => e.PanelValue).HasDefaultValue(0m);
            entity.Property(e => e.Priority).HasDefaultValue(0);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Team).HasDefaultValue(0);
        });

        modelBuilder.Entity<PlannedHoursPerWeek>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PlannedHoursPer Week$PrimaryKey");

            entity.Property(e => e.TotalHoursPerWeek).HasDefaultValue(0);
            entity.Property(e => e.TotalHoursPlanned).HasDefaultValue(0);
            entity.Property(e => e.WeeksPerPanel).HasDefaultValue(0);
            entity.Property(e => e.Ww1).HasDefaultValue(0);
            entity.Property(e => e.Year).HasDefaultValue(0);
        });

        modelBuilder.Entity<PlannedHoursPerWeekLinesAdded>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Planned Hours Per Week Lines Added$PrimaryKey");

            entity.Property(e => e.TotalHoursPerWeek).HasDefaultValue(0);
            entity.Property(e => e.TotalHoursPlanned).HasDefaultValue(0);
            entity.Property(e => e.WeeksPerPanel).HasDefaultValue(0);
            entity.Property(e => e.Year).HasDefaultValue(0);
        });

        modelBuilder.Entity<ProjectProductStructureTemp>(entity =>
        {
            entity.Property(e => e.ExistOrder).IsFixedLength();
            entity.Property(e => e.SerialTracking).IsFixedLength();
        });

        modelBuilder.Entity<SwitchgearTest>(entity =>
        {
            entity.ToView("switchgear_test");
        });

        modelBuilder.Entity<TblActivity>(entity =>
        {
            entity.Property(e => e.ActivitySeq).ValueGeneratedNever();
            entity.Property(e => e.ProductionStatus).HasDefaultValue(false);
            entity.Property(e => e.StoreStatus).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblAreaReportNewTimestamp>(entity =>
        {
            entity.Property(e => e.Employee).IsFixedLength();
            entity.Property(e => e.Operation).IsFixedLength();
        });

        modelBuilder.Entity<TblChecklistSnaglist>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TblChecklistTransaction>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblChecklistTransactionsDatum>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.TransactionDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TblClock>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblClockTransaction>(entity =>
        {
            entity.Property(e => e.TransactionDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TblDepartment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblEmail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC2721C4604D");
        });

        modelBuilder.Entity<TblInfo>(entity =>
        {
            entity.Property(e => e.Ifsqtyissued).HasDefaultValue(0f);
        });

        modelBuilder.Entity<TblLaborTimeStamp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbl_Labo__3214EC2755610DE2");

            entity.HasIndex(e => e.UserId, "one_open_timelog_per_user")
                .IsUnique()
                .HasFilter("([ClockOut] IS NULL)");

            entity.HasOne(d => d.Project).WithMany(p => p.TblLaborTimeStamps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ProjectID");

            entity.HasOne(d => d.User).WithOne(p => p.TblLaborTimeStamp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("UserID");
        });

        modelBuilder.Entity<TblPanelEarlyfinishTemplate>(entity =>
        {
            entity.Property(e => e.EarlyFinishDate).HasDefaultValue(0);
            entity.Property(e => e.IsBatch).HasDefaultValue(0);
        });

        modelBuilder.Entity<TblPerson>(entity =>
        {
            entity.Property(e => e.FormatedDate).HasComputedColumnSql("(CONVERT([varchar],[Date],(101)))", false);
        });

        modelBuilder.Entity<TblProject>(entity =>
        {
            entity.Property(e => e.DepartmentId).HasDefaultValue(1);
        });

        modelBuilder.Entity<TblProjectChecklist>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblSmdMaterialBorrowTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tbl_SMD_Material_Borrow");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TblStoreInfo>(entity =>
        {
            entity.Property(e => e.MaterialStatus).HasDefaultValue(false);
            entity.Property(e => e.MissingMaterial).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblStorePicklist>(entity =>
        {
            entity.Property(e => e.DateCreated).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.PicklistId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblStorePicklistItem>(entity =>
        {
            entity.Property(e => e.PicklistItemId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblStoreTransaction>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblSwgAreaReportTimestamp>(entity =>
        {
            entity.Property(e => e.Status).IsFixedLength();
            entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TblSwgAreaReportTimestampList>(entity =>
        {
            entity.HasKey(e => e.TimeStampId).HasName("PK__tbl_swg___B9C65336E2450461");

            entity.HasOne(d => d.Report).WithMany(p => p.TblSwgAreaReportTimestampLists).HasConstraintName("FK__tbl_swg_a__Repor__5A4F643B");
        });

        modelBuilder.Entity<TblTaskTemplate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblTempItemList>(entity =>
        {
            entity.Property(e => e.Status).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblTemplateArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsSub).IsFixedLength();
        });

        modelBuilder.Entity<TblTemplatePlanningArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tbl_template_area");
        });

        modelBuilder.Entity<TblTransaction>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblTransactionsArea>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblTransactionsPicture>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IsDraw).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblUpdateIfsEarlyFinishError>(entity =>
        {
            entity.Property(e => e.ReportDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TeamAssignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Team Assignments$PrimaryKey");
        });

        modelBuilder.Entity<TempStorePickListItem>(entity =>
        {
            entity.Property(e => e.PicklistItemId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TempStorePickListLocation>(entity =>
        {
            entity.Property(e => e.PicklistItemId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewActivityWithTeam>(entity =>
        {
            entity.ToView("view_activity with team");
        });

        modelBuilder.Entity<ViewFaAcbRow>(entity =>
        {
            entity.ToView("view_FA_ACB_ROW");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewFaCableacce>(entity =>
        {
            entity.ToView("view_FA_cableacces");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewFaCamlock>(entity =>
        {
            entity.ToView("view_FA_Camlock");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewFaControlDoor>(entity =>
        {
            entity.ToView("view_FA_Control_doors");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewFaFlange>(entity =>
        {
            entity.ToView("view_FA_Flange");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewFaMccbspd2ndFix>(entity =>
        {
            entity.ToView("view_FA_MCCBSPD_2ndFix");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewFaTime>(entity =>
        {
            entity.ToView("VIEW_FA_TIME");
        });

        modelBuilder.Entity<ViewFaTxCopper>(entity =>
        {
            entity.ToView("view_FA_TX_Copper");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewFaWeeklyPlan>(entity =>
        {
            entity.ToView("view_FA_weekly_plan");
        });

        modelBuilder.Entity<ViewFainterlinking>(entity =>
        {
            entity.ToView("view_FAInterlinking");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewIssue>(entity =>
        {
            entity.ToView("view_issues");
        });

        modelBuilder.Entity<ViewMa>(entity =>
        {
            entity.ToView("view_MAS");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewMasTime>(entity =>
        {
            entity.ToView("VIEW_MAS_TIME");
        });

        modelBuilder.Entity<ViewMasWeeklyPlan>(entity =>
        {
            entity.ToView("view_MAS_weekly_plan");
        });

        modelBuilder.Entity<ViewMaterialStatus>(entity =>
        {
            entity.ToView("View_material_status");
        });

        modelBuilder.Entity<ViewMisc>(entity =>
        {
            entity.ToView("view_Misc");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewProductionReportTime>(entity =>
        {
            entity.ToView("view_production_report_time");
        });

        modelBuilder.Entity<ViewQryTeamPlanning>(entity =>
        {
            entity.ToView("view_qry_team_planning");
        });

        modelBuilder.Entity<ViewReportByArea>(entity =>
        {
            entity.ToView("view_report_by_area");
        });

        modelBuilder.Entity<ViewSaDistBd>(entity =>
        {
            entity.ToView("view_SA_Dist_bd");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewSaMccbspdFitout>(entity =>
        {
            entity.ToView("view_SA_MCCBSPD_FITOUT");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewSaTime>(entity =>
        {
            entity.ToView("VIEW_SA_TIME");
        });

        modelBuilder.Entity<ViewSacamlock>(entity =>
        {
            entity.ToView("view_SACamlock");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewSacontrol>(entity =>
        {
            entity.ToView("View_SAControl");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewTempTime>(entity =>
        {
            entity.ToView("VIEW_TEMP_TIME");
        });

        modelBuilder.Entity<ViewTestAccTime>(entity =>
        {
            entity.ToView("view_test_acc_time");
        });

        modelBuilder.Entity<ViewTestMaxTime>(entity =>
        {
            entity.ToView("view_test_max_time");
        });

        modelBuilder.Entity<ViewTotalPanelInfoTime>(entity =>
        {
            entity.ToView("view_total_panel_info_time");
        });

        modelBuilder.Entity<ViewTransactionActivity>(entity =>
        {
            entity.ToView("view_transaction_activity");
        });

        modelBuilder.Entity<ViewTransactionsDistinct>(entity =>
        {
            entity.ToView("view_transactions_distinct");
        });

        modelBuilder.Entity<ViewUnionArea>(entity =>
        {
            entity.ToView("view_union_areas");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
