using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_template_areas")]
public partial class TblTemplateArea
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? ProductionArea { get; set; }

    [Column("DepartmentID")]
    public int? DepartmentId { get; set; }

    [Column("isSub")]
    [StringLength(10)]
    public string? IsSub { get; set; }
}
