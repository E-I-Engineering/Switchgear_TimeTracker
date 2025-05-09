using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
public partial class ViewSaTime
{
    [Column(TypeName = "datetime")]
    public DateTime? FinalTime { get; set; }

    [Column("Production_Status")]
    public bool? ProductionStatus { get; set; }

    [Column("ACTIVITY_SEQ")]
    public int ActivitySeq { get; set; }

    [Column("PROJECT_ID")]
    [StringLength(50)]
    public string ProjectId { get; set; } = null!;

    [Column("Project_Name")]
    public string? ProjectName { get; set; }

    [StringLength(50)]
    public string? Area { get; set; }

    public string? Switchboard { get; set; }
}
