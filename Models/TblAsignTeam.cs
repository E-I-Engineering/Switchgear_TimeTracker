using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_asign_team")]
[Index("ActivitySeq", Name = "IX_ABC", IsUnique = true)]
[Index("ActivitySequence", Name = "NonClusteredIndex-20210903-085947")]
[Index("SubProjectId", Name = "NonClusteredIndex-20210903-090203")]
public partial class TblAsignTeam
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

    [Column("activity_seq", TypeName = "numeric(18, 0)")]
    public decimal ActivitySeq { get; set; }

    [Column("Activity Sequence", TypeName = "numeric(18, 0)")]
    public decimal? ActivitySequence { get; set; }

    [Column("Complettion_Due_date", TypeName = "datetime")]
    public DateTime? ComplettionDueDate { get; set; }
}
