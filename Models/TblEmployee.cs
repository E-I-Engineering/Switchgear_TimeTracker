using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_Employees")]
public partial class TblEmployee
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FullName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    public int? ClockNumber { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<TblLaborTimeStamp> TblLaborTimeStamps { get; set; } = new List<TblLaborTimeStamp>();
}
