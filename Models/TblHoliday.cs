using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tblHolidays")]
public partial class TblHoliday
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? HolidayName { get; set; }

    public DateOnly? HolDate { get; set; }

    [StringLength(50)]
    public string? HolWeekday { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal HolYear { get; set; }
}
