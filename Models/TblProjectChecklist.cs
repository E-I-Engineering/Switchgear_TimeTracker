using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_project_checklist")]
public partial class TblProjectChecklist
{
    [Column("Department_ID")]
    public int? DepartmentId { get; set; }

    [Column("ID")]
    public int Id { get; set; }

    [Column("Project_No")]
    [StringLength(255)]
    public string? ProjectNo { get; set; }
}
