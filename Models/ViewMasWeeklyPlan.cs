using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
public partial class ViewMasWeeklyPlan
{
    [Column("Activity Sequence", TypeName = "numeric(18, 0)")]
    public decimal? ActivitySequence { get; set; }

    [Column("EARLY_FINISH", TypeName = "datetime")]
    public DateTime? EarlyFinish { get; set; }

    [Column("PROJECT_ID")]
    [StringLength(255)]
    public string? ProjectId { get; set; }

    [Column("PROJECT_NAME")]
    [StringLength(255)]
    public string? ProjectName { get; set; }

    [Column("SUB_PROJECT_ID")]
    [StringLength(255)]
    public string? SubProjectId { get; set; }

    [Column("ACTIVITY_NO")]
    [StringLength(255)]
    public string? ActivityNo { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(255)]
    public string? Description { get; set; }

    [Column("STATE")]
    [StringLength(255)]
    public string? State { get; set; }

    [Column("manager")]
    [StringLength(255)]
    public string? Manager { get; set; }

    [Column("Production_Status")]
    public bool? ProductionStatus { get; set; }

    [Column("activity_seq")]
    public int ActivitySeq { get; set; }

    [Column("Team Number")]
    [StringLength(255)]
    public string? TeamNumber { get; set; }

    [Column("FINISH BY", TypeName = "datetime")]
    public DateTime? FinishBy { get; set; }
}
