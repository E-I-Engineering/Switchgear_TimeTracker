using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_clock_transactions")]
public partial class TblClockTransaction
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("Proj_ID")]
    public int? ProjId { get; set; }

    [StringLength(50)]
    public string? Action { get; set; }

    public string? Notes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransactionDate { get; set; }
}
