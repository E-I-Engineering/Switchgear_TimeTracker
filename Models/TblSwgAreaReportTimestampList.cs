using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_swg_area_report_timestamp_list")]
public partial class TblSwgAreaReportTimestampList
{
    [Key]
    [Column("TimeStampID")]
    public int TimeStampId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ClockNumber { get; set; }

    [Column("ReportID")]
    public int? ReportId { get; set; }

    [ForeignKey("ReportId")]
    [InverseProperty("TblSwgAreaReportTimestampLists")]
    public virtual TblSwgAreaReportTimestamp? Report { get; set; }
}
