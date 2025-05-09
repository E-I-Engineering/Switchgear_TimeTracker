using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_store_info")]
public partial class TblStoreInfo
{
    [Column("SEQ_NO", TypeName = "numeric(18, 0)")]
    public decimal? SeqNo { get; set; }

    [Column("PARENT_SEQ_NO", TypeName = "numeric(18, 0)")]
    public decimal? ParentSeqNo { get; set; }

    [Column("PROJECT_ID")]
    [StringLength(255)]
    public string? ProjectId { get; set; }

    [Column("SORTING_CODE", TypeName = "numeric(18, 0)")]
    public decimal? SortingCode { get; set; }

    [Column("PART_NO")]
    [StringLength(255)]
    public string? PartNo { get; set; }

    [Column("QTY", TypeName = "numeric(18, 0)")]
    public decimal? Qty { get; set; }

    [Column("QTY_ISSUED", TypeName = "numeric(18, 0)")]
    public decimal? QtyIssued { get; set; }

    [StringLength(255)]
    public string? Area { get; set; }

    [Column("Area_Description")]
    [StringLength(255)]
    public string? AreaDescription { get; set; }

    [Column("SUB_PROJECT_ID")]
    [StringLength(255)]
    public string? SubProjectId { get; set; }

    [Column("QTY_Received", TypeName = "numeric(18, 0)")]
    public decimal? QtyReceived { get; set; }

    [Column("Material_Status")]
    public bool? MaterialStatus { get; set; }

    [Column("Material_Notes")]
    [StringLength(255)]
    public string? MaterialNotes { get; set; }

    [Column("Missing_Material")]
    public bool? MissingMaterial { get; set; }
}
