using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_activity")]
public partial class TblActivity
{
    [Key]
    [Column("activity_seq")]
    public int ActivitySeq { get; set; }

    [Column("PROJECT_ID")]
    [StringLength(255)]
    public string? ProjectId { get; set; }

    [Column("PROJECT_NAME")]
    [StringLength(255)]
    public string? ProjectName { get; set; }

    [Column("SUB_PROJECT_ID")]
    [StringLength(255)]
    public string? SubProjectId { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(255)]
    public string? Description { get; set; }

    [Column("ACTIVITY_NO")]
    [StringLength(255)]
    public string? ActivityNo { get; set; }

    [Column("EARLY_START", TypeName = "datetime")]
    public DateTime? EarlyStart { get; set; }

    [Column("EARLY_FINISH", TypeName = "datetime")]
    public DateTime? EarlyFinish { get; set; }

    [Column("RELEASED_DATE", TypeName = "datetime")]
    public DateTime? ReleasedDate { get; set; }

    [Column("COMPLETED_DATE", TypeName = "datetime")]
    public DateTime? CompletedDate { get; set; }

    [Column("CLOSED_DATE", TypeName = "datetime")]
    public DateTime? ClosedDate { get; set; }

    [Column("DATE_CREATED", TypeName = "datetime")]
    public DateTime? DateCreated { get; set; }

    [Column("MODIFIED_BY")]
    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    [Column("STATE")]
    [StringLength(255)]
    public string? State { get; set; }

    [Column("matl_count", TypeName = "numeric(18, 0)")]
    public decimal? MatlCount { get; set; }

    [Column("manager")]
    [StringLength(255)]
    public string? Manager { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Priority { get; set; }

    [Column("Store_Due_date", TypeName = "datetime")]
    public DateTime? StoreDueDate { get; set; }

    [Column("Store_Status")]
    public bool? StoreStatus { get; set; }

    [Column("Production_Status")]
    public bool? ProductionStatus { get; set; }

    [Column("Production_Note")]
    public string? ProductionNote { get; set; }

    [Column("Team_Number")]
    [StringLength(50)]
    public string? TeamNumber { get; set; }

    [Column("SMD_Due_date", TypeName = "datetime")]
    public DateTime? SmdDueDate { get; set; }

    [Column("SMD_Status")]
    public bool? SmdStatus { get; set; }
}
