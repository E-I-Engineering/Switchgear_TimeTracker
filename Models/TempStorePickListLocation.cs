using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("temp_store_pick_list_locations")]
public partial class TempStorePickListLocation
{
    [Column("PicklistItemID")]
    public int PicklistItemId { get; set; }

    [Column("PicklistID")]
    public int? PicklistId { get; set; }

    [Column("SEQ_NO", TypeName = "numeric(18, 0)")]
    public decimal? SeqNo { get; set; }

    [Column("ACTIVITY_SEQ", TypeName = "numeric(18, 0)")]
    public decimal? ActivitySeq { get; set; }

    public string? PartNo { get; set; }

    [Column("DESCRIPTION")]
    public string? Description { get; set; }

    [Column("RequiredQTY", TypeName = "numeric(18, 0)")]
    public decimal? RequiredQty { get; set; }

    [Column("IssuedQTY", TypeName = "numeric(18, 0)")]
    public decimal? IssuedQty { get; set; }

    [StringLength(50)]
    public string? Location { get; set; }

    [Column("WAREHOUSE")]
    [StringLength(50)]
    public string? Warehouse { get; set; }

    [Column("BAY_NO")]
    [StringLength(50)]
    public string? BayNo { get; set; }

    [Column("ROW_NO")]
    [StringLength(50)]
    public string? RowNo { get; set; }

    [Column("TIER_NO")]
    [StringLength(50)]
    public string? TierNo { get; set; }

    [Column("BIN_NO")]
    [StringLength(50)]
    public string? BinNo { get; set; }

    [Column("LOT_BATCH_NO")]
    public string? LotBatchNo { get; set; }

    [Column("SERIAL_NO")]
    public string? SerialNo { get; set; }

    [Column("CONFIGURATION_ID")]
    [StringLength(50)]
    public string? ConfigurationId { get; set; }

    [Column("ENG_CHG_LEVEL", TypeName = "numeric(18, 0)")]
    public decimal? EngChgLevel { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IssuedDate { get; set; }

    [Column("MRP_Code")]
    public int? MrpCode { get; set; }

    [Column("temp_issued_qty", TypeName = "numeric(18, 0)")]
    public decimal? TempIssuedQty { get; set; }

    [Column("OBJID")]
    public string? Objid { get; set; }

    [Column("OBJVERSION")]
    public string? Objversion { get; set; }
}
