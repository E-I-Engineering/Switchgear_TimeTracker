using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_transactions_area")]
public partial class TblTransactionsArea
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("Project_ID")]
    public int? ProjectId { get; set; }

    [Column("Area_ID")]
    public int? AreaId { get; set; }
}
