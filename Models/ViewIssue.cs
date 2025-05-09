using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
public partial class ViewIssue
{
    [Column("editDate1", TypeName = "datetime")]
    public DateTime? EditDate1 { get; set; }

    [Column("EARLY_FINISH", TypeName = "datetime")]
    public DateTime? EarlyFinish { get; set; }

    [Column("userid")]
    public int? Userid { get; set; }

    [Column("PART_NO")]
    public string PartNo { get; set; } = null!;

    [Column("REQUIRE_QTY")]
    public float? RequireQty { get; set; }

    [Column("Missing_Material")]
    public bool MissingMaterial { get; set; }

    public bool Status { get; set; }

    [Column("Received_QTY")]
    public float? ReceivedQty { get; set; }

    [Column("Installed_QTY")]
    public float? InstalledQty { get; set; }

    [Column("Production_Status")]
    public bool ProductionStatus { get; set; }

    [Column("Production_Notes")]
    public string? ProductionNotes { get; set; }

    public string? Notes { get; set; }

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

    [StringLength(50)]
    public string? Area { get; set; }

    [Column("Area_Description")]
    public string? AreaDescription { get; set; }
}
