using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_swg_report_area")]
public partial class TblSwgReportArea
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string Area { get; set; } = null!;

    [StringLength(50)]
    public string? ColumnName { get; set; }

    [StringLength(50)]
    public string? StartColumn { get; set; }
}
