using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_area_report_new_timestamp")]
public partial class TblAreaReportNewTimestamp
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("Area_ID")]
    public int? AreaId { get; set; }

    [StringLength(10)]
    public string? Operation { get; set; }

    [StringLength(10)]
    public string? Employee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TimeStamp { get; set; }

    [Column("PanelID")]
    public int? PanelId { get; set; }

    [StringLength(50)]
    public string? PanelNumber { get; set; }

    [StringLength(50)]
    public string? ReportStatus { get; set; }
}
