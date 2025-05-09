using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_transactions")]
public partial class TblTransaction
{
    [Column("MATR_SEQ_NO")]
    [StringLength(50)]
    public string? MatrSeqNo { get; set; }

    [Column("id")]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EditDate { get; set; }

    [Column("userid")]
    public int? Userid { get; set; }

    [StringLength(255)]
    public string? Notes { get; set; }

    public bool? Status { get; set; }

    [Column("Missing_Material")]
    public bool? MissingMaterial { get; set; }

    [Column("Received_QTY")]
    public float? ReceivedQty { get; set; }

    [Column("Installed_QTY")]
    public float? InstalledQty { get; set; }

    [Column("Production_Status")]
    public bool? ProductionStatus { get; set; }

    [Column("Production_Notes")]
    [StringLength(255)]
    public string? ProductionNotes { get; set; }
}
