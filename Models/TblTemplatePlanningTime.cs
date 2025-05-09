using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_template_planning_time")]
public partial class TblTemplatePlanningTime
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("AreaID")]
    public int? AreaId { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Time { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    public int? ActionOrder { get; set; }
}
