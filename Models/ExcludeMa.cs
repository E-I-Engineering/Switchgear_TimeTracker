using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("Exclude MAS")]
public partial class ExcludeMa
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("EARLY FINISH", TypeName = "datetime")]
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

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Field6 { get; set; }

    [StringLength(255)]
    public string? Field7 { get; set; }

    [Column("Activity Sequence", TypeName = "numeric(18, 0)")]
    public decimal? ActivitySequence { get; set; }
}
