using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_teams")]
public partial class TblTeam
{
    [StringLength(50)]
    public string? TeamNumber { get; set; }

    [Column("MAS", TypeName = "datetime")]
    public DateTime? Mas { get; set; }
}
