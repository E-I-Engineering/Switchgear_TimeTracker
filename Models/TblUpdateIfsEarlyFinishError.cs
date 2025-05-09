using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_update_ifs_early_finish_error")]
public partial class TblUpdateIfsEarlyFinishError
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    public string? Project { get; set; }

    [StringLength(255)]
    public string? Panel { get; set; }

    [Column("Final_panel")]
    [StringLength(255)]
    public string? FinalPanel { get; set; }

    [StringLength(255)]
    public string? Activity { get; set; }

    [StringLength(255)]
    public string? Notes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReportDate { get; set; }
}
