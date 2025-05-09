using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_temp_item_list")]
public partial class TblTempItemList
{
    [Column("PicklistID")]
    public int? PicklistId { get; set; }

    [Column("OBJVERSION")]
    public string? Objversion { get; set; }

    [Column("OBJID")]
    public string? Objid { get; set; }

    [Column("REQ_SEQ_NO", TypeName = "numeric(18, 0)")]
    public decimal? ReqSeqNo { get; set; }

    [Column("SUB_PROJECT_ID")]
    [StringLength(50)]
    public string? SubProjectId { get; set; }

    [Column("ACTIVITY_NO")]
    [StringLength(50)]
    public string? ActivityNo { get; set; }

    [Column("ACTIVITY_SEQ", TypeName = "numeric(18, 0)")]
    public decimal? ActivitySeq { get; set; }

    [Column("SEQ_NO", TypeName = "numeric(18, 0)")]
    public decimal? SeqNo { get; set; }

    [Column("PART_NO")]
    public string? PartNo { get; set; }

    [Column("PART_REV")]
    [StringLength(50)]
    public string? PartRev { get; set; }

    [Column("DESCRIPTION")]
    public string Description { get; set; } = null!;

    [Column("SITE")]
    [StringLength(50)]
    public string? Site { get; set; }

    [Column("REQUIRE_QTY", TypeName = "numeric(18, 0)")]
    public decimal? RequireQty { get; set; }

    [Column("ISSUED_QTY", TypeName = "numeric(18, 0)")]
    public decimal? IssuedQty { get; set; }

    [Column("MRP_CODE")]
    [StringLength(50)]
    public string? MrpCode { get; set; }

    public bool? Status { get; set; }

    [Column("Project_ID")]
    [StringLength(50)]
    public string? ProjectId { get; set; }
}
