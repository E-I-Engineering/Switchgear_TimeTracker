using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("Planned Hours Per Week Lines Added")]
public partial class PlannedHoursPerWeekLinesAdded
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("Start_D")]
    [StringLength(255)]
    public string? StartD { get; set; }

    [Column("Project # ENG")]
    [StringLength(255)]
    public string? ProjectEng { get; set; }

    [Column("Panel #")]
    [StringLength(255)]
    public string? Panel { get; set; }

    [Column("Total Hours Planned")]
    public int? TotalHoursPlanned { get; set; }

    [Column("Total Hours Per Week")]
    public int? TotalHoursPerWeek { get; set; }

    [Column("Weeks Per Panel")]
    public int? WeeksPerPanel { get; set; }

    public int? Year { get; set; }

    [Column("Start_Date")]
    [StringLength(255)]
    public string? StartDate { get; set; }
}
