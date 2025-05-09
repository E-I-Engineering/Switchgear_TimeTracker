using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
public partial class ViewQryTeamPlanning
{
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

    public int? ActionOrder { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? ProjectNumber { get; set; }

    [StringLength(50)]
    public string? PanelNumber { get; set; }

    [Column("Panel Value", TypeName = "money")]
    public decimal? PanelValue { get; set; }

    public int? Team { get; set; }

    [StringLength(255)]
    public string? Status { get; set; }

    [Column("Production Completion Date", TypeName = "datetime")]
    public DateTime? ProductionCompletionDate { get; set; }
}
