using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("temp_tbl_template_planning_panel_info")]
public partial class TempTblTemplatePlanningPanelInfo
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ActionID")]
    public int? ActionId { get; set; }

    [Column("ProjectID")]
    public int? ProjectId { get; set; }

    [Column("PannelID")]
    public int? PannelId { get; set; }

    [Column("AreaID")]
    public int? AreaId { get; set; }

    [Column("QTY", TypeName = "numeric(18, 0)")]
    public decimal? Qty { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Time { get; set; }

    public string? Notes { get; set; }
}
