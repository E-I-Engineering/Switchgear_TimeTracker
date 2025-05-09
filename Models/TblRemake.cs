using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_remakes")]
public partial class TblRemake
{
    [Column("MATR_SEQ_NO")]
    public int? MatrSeqNo { get; set; }

    [Column("ACTIVITY_SEQ")]
    public int? ActivitySeq { get; set; }

    [Column("PART_NO")]
    public string? PartNo { get; set; }

    [Column("Remake_QTY", TypeName = "numeric(18, 0)")]
    public decimal? RemakeQty { get; set; }

    [Column("Remake_Notes")]
    public string? RemakeNotes { get; set; }

    [Column("Remake_Status")]
    public bool? RemakeStatus { get; set; }

    [Column("Requested_Date", TypeName = "datetime")]
    public DateTime? RequestedDate { get; set; }

    [Column("Requested_Person")]
    [StringLength(50)]
    public string? RequestedPerson { get; set; }
}
