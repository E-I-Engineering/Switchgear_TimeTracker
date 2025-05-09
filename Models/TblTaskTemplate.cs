using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_task_template")]
public partial class TblTaskTemplate
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("AreaID")]
    public int? AreaId { get; set; }

    public string? TaskDescription { get; set; }
}
