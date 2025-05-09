using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_misc")]
public partial class TblMisc
{
    [Column("info")]
    public string? Info { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }
}
