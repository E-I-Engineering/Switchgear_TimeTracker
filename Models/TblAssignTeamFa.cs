using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_assign_team_FA")]
[Index("ActivitySequence", Name = "IX_tbl_assign_team_FA", IsUnique = true)]
public partial class TblAssignTeamFa
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("Team Number")]
    [StringLength(255)]
    public string? TeamNumber { get; set; }

    [Column("PROJECT ID")]
    [StringLength(50)]
    public string? ProjectId { get; set; }

    [Column("PROJECT NAME")]
    [StringLength(255)]
    public string? ProjectName { get; set; }

    [Column("SUB_PROJECT ID")]
    [StringLength(255)]
    public string? SubProjectId { get; set; }

    [Column("DESCRIPTION 1")]
    [StringLength(255)]
    public string? Description1 { get; set; }

    [Column("ACTIVITY NO")]
    [StringLength(50)]
    public string? ActivityNo { get; set; }

    [Column("EARLY FINISH", TypeName = "datetime")]
    public DateTime? EarlyFinish { get; set; }

    [Column("FINISH BY", TypeName = "datetime")]
    public DateTime? FinishBy { get; set; }

    [Column("Activity Sequence", TypeName = "numeric(18, 0)")]
    public decimal ActivitySequence { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Field10 { get; set; }

    [Column("Complettion_Due_date", TypeName = "datetime")]
    public DateTime? ComplettionDueDate { get; set; }
}
