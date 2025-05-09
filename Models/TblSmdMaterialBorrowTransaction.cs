using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_SMD_Material_Borrow_Transactions")]
public partial class TblSmdMaterialBorrowTransaction
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("OLD_MATR_SEQ_NO")]
    public int? OldMatrSeqNo { get; set; }

    [Column("NEW_MATR_SEQ_NO")]
    public int? NewMatrSeqNo { get; set; }

    [Column("Borrow_QTY", TypeName = "numeric(18, 0)")]
    public decimal? BorrowQty { get; set; }

    [StringLength(50)]
    public string? ClockNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("OLD_Area")]
    [StringLength(50)]
    public string? OldArea { get; set; }

    [Column("NEW_Area")]
    [StringLength(50)]
    public string? NewArea { get; set; }

    [Column("OLD_PROJECT_ID")]
    [StringLength(50)]
    public string? OldProjectId { get; set; }

    [Column("NEW_PROJECT_ID")]
    [StringLength(50)]
    public string? NewProjectId { get; set; }

    public int? IsError { get; set; }

    [Column("isMoved")]
    public int? IsMoved { get; set; }
}
