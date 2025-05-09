using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
public partial class ViewUnionArea
{
    [StringLength(24)]
    [Unicode(false)]
    public string Area { get; set; } = null!;

    [Column("ID")]
    public int Id { get; set; }

    [Column("Labour ", TypeName = "money")]
    public decimal? Labour { get; set; }

    [Column("Project # ENG")]
    [StringLength(50)]
    public string? ProjectEng { get; set; }

    [Column("IFS item #")]
    public double? IfsItem { get; set; }

    [Column("Project Description")]
    [StringLength(255)]
    public string? ProjectDescription { get; set; }

    [Column("Panel #")]
    [StringLength(50)]
    public string? Panel { get; set; }

    [Column("Panel  Discription")]
    [StringLength(255)]
    public string? PanelDiscription { get; set; }

    [Column("Panel Value", TypeName = "money")]
    public decimal? PanelValue { get; set; }

    [Column("Notes/Comments")]
    public string? NotesComments { get; set; }

    [StringLength(255)]
    public string? Status { get; set; }

    public int? Priority { get; set; }

    public int? Team { get; set; }

    [Column("Production Completion Date", TypeName = "datetime")]
    public DateTime? ProductionCompletionDate { get; set; }
}
