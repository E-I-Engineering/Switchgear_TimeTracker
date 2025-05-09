using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
public partial class ViewTestAccTime
{
    public int? ActionOrder { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? RunningTime { get; set; }

    [Column("acc_wsum", TypeName = "numeric(38, 0)")]
    public decimal? AccWsum { get; set; }
}
