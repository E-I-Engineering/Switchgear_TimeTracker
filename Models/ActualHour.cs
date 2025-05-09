using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("Actual_Hours")]
public partial class ActualHour
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(20)]
    public string? Name { get; set; }

    public DateOnly? Date { get; set; }

    [Column("Project_#")]
    [StringLength(50)]
    public string? Project { get; set; }

    [Column("Panel_#")]
    [StringLength(50)]
    public string? Panel { get; set; }

    [StringLength(50)]
    public string? Area { get; set; }

    [Column("Actual_Hours", TypeName = "decimal(15, 2)")]
    public decimal? ActualHours { get; set; }
}
