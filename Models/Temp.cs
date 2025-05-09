using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("Temp")]
public partial class Temp
{
    [Column("PART_NO")]
    public string PartNo { get; set; } = null!;
}
