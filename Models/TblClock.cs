using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_clock")]
public partial class TblClock
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? ProjectNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [StringLength(50)]
    public string Status { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? StoppedTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartTime { get; set; }
}
