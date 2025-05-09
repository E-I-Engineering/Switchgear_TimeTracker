using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_info")]
public partial class TblInfo
{
    [Column("MATR_SEQ_NO")]
    public int MatrSeqNo { get; set; }

    [Column("ACTIVITY_SEQ")]
    public int ActivitySeq { get; set; }

    [Column("PROJECT_ID")]
    [StringLength(50)]
    public string ProjectId { get; set; } = null!;

    [Column("Project_Name")]
    public string? ProjectName { get; set; }

    public string? Switchboard { get; set; }

    [Column("SITE")]
    [StringLength(10)]
    public string Site { get; set; } = null!;

    [Column("REQUIRE_QTY")]
    public float? RequireQty { get; set; }

    [StringLength(50)]
    public string? Area { get; set; }

    [Column("Area_Description")]
    public string? AreaDescription { get; set; }

    public bool Status { get; set; }

    [Column("Missing_Material")]
    public bool MissingMaterial { get; set; }

    public string? Notes { get; set; }

    [Column("Received_QTY")]
    public float? ReceivedQty { get; set; }

    [Column("Installed_QTY")]
    public float? InstalledQty { get; set; }

    [Column("Production_Status")]
    public bool ProductionStatus { get; set; }

    [Column("Production_Notes")]
    public string? ProductionNotes { get; set; }

    [Column("Report_notes")]
    public string? ReportNotes { get; set; }

    [Column("Report_department")]
    [StringLength(50)]
    public string? ReportDepartment { get; set; }

    [Column("Report_modified_date", TypeName = "datetime")]
    public DateTime? ReportModifiedDate { get; set; }

    [Column("IFSQTYISSUED")]
    public float? Ifsqtyissued { get; set; }

    [Column("PART_NO")]
    [StringLength(255)]
    public string? PartNo { get; set; }
}
