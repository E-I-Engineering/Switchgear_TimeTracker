using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_store_transactions")]
public partial class TblStoreTransaction
{
    [Column("id")]
    public int Id { get; set; }

    [Column("PicklistID")]
    public int? PicklistId { get; set; }

    [Column("OBJID")]
    public string? Objid { get; set; }

    [Column("REQ_SEQ_NO", TypeName = "numeric(18, 0)")]
    public decimal? ReqSeqNo { get; set; }

    [Column("SUB_PROJECT_ID")]
    [StringLength(50)]
    public string? SubProjectId { get; set; }

    [Column("ACTIVITY_NO", TypeName = "numeric(18, 0)")]
    public decimal? ActivityNo { get; set; }

    [Column("PART_NO")]
    public string? PartNo { get; set; }

    [Column("MRP_CODE", TypeName = "numeric(18, 0)")]
    public decimal? MrpCode { get; set; }

    [Column("Project_ID")]
    [StringLength(50)]
    public string? ProjectId { get; set; }

    [Column("Picked_qty", TypeName = "numeric(18, 0)")]
    public decimal? PickedQty { get; set; }

    [Column("Date_picked", TypeName = "datetime")]
    public DateTime? DatePicked { get; set; }

    [Column("LOCATION_NO")]
    public string? LocationNo { get; set; }

    [StringLength(50)]
    public string? Operator { get; set; }

    [Column("Project_activity_seq", TypeName = "numeric(18, 0)")]
    public decimal? ProjectActivitySeq { get; set; }
}
