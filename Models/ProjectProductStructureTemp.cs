using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("ProjectProductStructureTemp")]
public partial class ProjectProductStructureTemp
{
    [Column("OBJID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Objid { get; set; }

    [Column("OBJVERSION")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Objversion { get; set; }

    [Column("OBJSTATE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Objstate { get; set; }

    [Column("OBJEVENTS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Objevents { get; set; }

    [Column("PROJECT_ID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectId { get; set; }

    [Column("SORTING_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SortingCode { get; set; }

    [Column("SEQ_NO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SeqNo { get; set; }

    [Column("PARENT_SEQ_NO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ParentSeqNo { get; set; }

    [Column("PART_NO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PartNo { get; set; }

    [Column("PART_REV")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PartRev { get; set; }

    [Column("PART_NAME")]
    [StringLength(255)]
    [Unicode(false)]
    public string? PartName { get; set; }

    [Column("PART_DESCRIPTION")]
    [StringLength(255)]
    [Unicode(false)]
    public string? PartDescription { get; set; }

    [Column("SPARE_LIST_EXIST")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SpareListExist { get; set; }

    [Column("CHILDREN_COUNT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ChildrenCount { get; set; }

    [Column("SERIAL_NO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SerialNo { get; set; }

    [Column("PART_OWNERSHIP")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PartOwnership { get; set; }

    [Column("QTY")]
    public int? Qty { get; set; }

    [Column("QTY_RECEIVED")]
    public int? QtyReceived { get; set; }

    [Column("DT_RECEIVED", TypeName = "datetime")]
    public DateTime? DtReceived { get; set; }

    [Column("QTY_ISSUED")]
    public int? QtyIssued { get; set; }

    [Column("DT_ISSUED", TypeName = "datetime")]
    public DateTime? DtIssued { get; set; }

    [Column("QTY_ASSIGNED")]
    public int? QtyAssigned { get; set; }

    [Column("REQUIRED_QTY")]
    public int? RequiredQty { get; set; }

    [Column("UNIT_CODE")]
    [StringLength(20)]
    [Unicode(false)]
    public string? UnitCode { get; set; }

    [Column("STATE")]
    [StringLength(20)]
    [Unicode(false)]
    public string? State { get; set; }

    [Column("TAG_NO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TagNo { get; set; }

    [Column("POS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Pos { get; set; }

    [Column("LOCATION")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Location { get; set; }

    [Column("MRP_CODE")]
    [StringLength(20)]
    [Unicode(false)]
    public string? MrpCode { get; set; }

    [Column("SITE")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Site { get; set; }

    [Column("AQUISITION_CODE")]
    [StringLength(20)]
    [Unicode(false)]
    public string? AquisitionCode { get; set; }

    [Column("NETTING")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Netting { get; set; }

    [Column("SUPPLY_OPTION")]
    [StringLength(20)]
    [Unicode(false)]
    public string? SupplyOption { get; set; }

    [Column("ACTUAL_SITE")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ActualSite { get; set; }

    [Column("OPERATION_LIST_TEMPLATE")]
    [StringLength(100)]
    [Unicode(false)]
    public string? OperationListTemplate { get; set; }

    [Column("INFORMATION")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Information { get; set; }

    [Column("ACTIVITY_SEQ")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ActivitySeq { get; set; }

    [Column("SUB_PROJECT_ACTIVITY")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SubProjectActivity { get; set; }

    [Column("SERIAL_TRACKING")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SerialTracking { get; set; }

    [Column("EXIST_ORDER")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExistOrder { get; set; }

    [Column("QTY_DB")]
    public int? QtyDb { get; set; }

    [Column("MRP_CODE_DB")]
    [StringLength(20)]
    [Unicode(false)]
    public string? MrpCodeDb { get; set; }

    [Column("POS_DB")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PosDb { get; set; }

    [Column("PART_OWNERSHIP_DB")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PartOwnershipDb { get; set; }

    [Column("SUPPLY_OPTION_DB")]
    [StringLength(20)]
    [Unicode(false)]
    public string? SupplyOptionDb { get; set; }

    [Column("OBJID_REV")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ObjidRev { get; set; }
}
