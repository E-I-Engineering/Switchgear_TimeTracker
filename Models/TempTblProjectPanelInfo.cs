using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("temp_tbl_project_panel_info")]
public partial class TempTblProjectPanelInfo
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? ProjectNumber { get; set; }

    [Column("ProjectID")]
    public int? ProjectId { get; set; }

    [StringLength(50)]
    public string? PanelNumber { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? LaborValue { get; set; }

    [StringLength(255)]
    public string? PanelType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProposedStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProposedFinishDate { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? TotalTime { get; set; }
}
