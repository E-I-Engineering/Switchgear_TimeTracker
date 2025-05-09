using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_swg_area_report_timestamp")]
public partial class TblSwgAreaReportTimestamp
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TimeStamp { get; set; }

    [StringLength(50)]
    public string? Barcode { get; set; }

    [StringLength(50)]
    public string? Project { get; set; }

    [StringLength(50)]
    public string? Panel { get; set; }

    [StringLength(50)]
    public string? ReportedBy { get; set; }

    public string? Notes { get; set; }

    [StringLength(10)]
    public string? Status { get; set; }

    [StringLength(50)]
    public string? AreaName { get; set; }

    public int? AreaCode { get; set; }

    [StringLength(50)]
    public string? AreaColumn { get; set; }

    [StringLength(255)]
    public string? ReportedEmail { get; set; }

    [InverseProperty("Report")]
    public virtual ICollection<TblSwgAreaReportTimestampList> TblSwgAreaReportTimestampLists { get; set; } = new List<TblSwgAreaReportTimestampList>();
}
