using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("Team Assignments")]
public partial class TeamAssignment
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("Blue Shirt Name")]
    [StringLength(255)]
    public string? BlueShirtName { get; set; }

    [StringLength(255)]
    public string? Team { get; set; }

    [Column("Total_Worker", TypeName = "numeric(18, 0)")]
    public decimal? TotalWorker { get; set; }
}
