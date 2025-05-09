using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_import_clock_data1")]
public partial class TblImportClockData1
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public double? Hours { get; set; }

    [StringLength(255)]
    public string? Job { get; set; }

    public DateOnly Date { get; set; }

    [StringLength(255)]
    public string? Notes { get; set; }
}
