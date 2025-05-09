using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_emails")]
public partial class TblEmail
{
    [Column("emails")]
    public string? Emails { get; set; }

    [Column("ID")]
    public int Id { get; set; }
}
