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

    public virtual DbSet<TblEmployee> TblEmployees { get; set; }

    public virtual DbSet<TblLaborTimeStamp> TblLaborTimeStamps { get; set; }

    public virtual DbSet<TblProject> TblProjects { get; set; }

    public virtual DbSet<TblProjectPanelInfo> TblProjectPanelInfos { get; set; }

    public virtual DbSet<TblDowntimeReason> TblDowntimeReasons { get; set; }

    public virtual DbSet<TblTemplatePlanningArea> TblTemplatePlanningAreas { get; set; }

    public virtual DbSet<TblTemplatePlanningPanelInfo> TblTemplatePlanningPanelInfos { get; set; }

    public virtual DbSet<TblTemplatePlanningTime> TblTemplatePlanningTimes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=SCSQL01;Initial Catalog=us_switchgear;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<TblEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC2721C4604D");
        });

        modelBuilder.Entity<TblLaborTimeStamp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbl_Labo__3214EC2755610DE2");

            entity.HasIndex(e => e.UserId, "one_open_timelog_per_user")
                .IsUnique()
                .HasFilter("([ClockOut] IS NULL)");

            entity.HasOne(d => d.User).WithMany(p => p.TblLaborTimeStamps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("UserID");
        });

        modelBuilder.Entity<TblProject>(entity =>
        {
            entity.Property(e => e.DepartmentId).HasDefaultValue(1);
        });

        modelBuilder.Entity<TblTemplatePlanningArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tbl_template_area");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
