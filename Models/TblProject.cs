using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_projects")]
public partial class TblProject
{
    [Column("Department_ID")]
    public int? DepartmentId { get; set; }

    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("Project_No")]
    [StringLength(50)]
    public string? ProjectNo { get; set; }

    [InverseProperty("Project")]
    public virtual ICollection<TblLaborTimeStamp> TblLaborTimeStamps { get; set; } = new List<TblLaborTimeStamp>();
}
