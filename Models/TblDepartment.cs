using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_departments")]
public partial class TblDepartment
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? DepartmentName { get; set; }
}
