using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
public partial class ViewTestMaxTime
{
    public int? ActionOrder { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? RunningTime { get; set; }
}
