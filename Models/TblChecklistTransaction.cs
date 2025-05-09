using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_checklist_transactions")]
public partial class TblChecklistTransaction
{
    [Column("Transaction_area_id")]
    public int? TransactionAreaId { get; set; }

    [Column("ID")]
    public int Id { get; set; }

    [Column("Created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("Created_by")]
    public string? CreatedBy { get; set; }

    public string? PanelNumber { get; set; }

    public string? AdditionalNotes { get; set; }

    public string? EngineerNotes { get; set; }

    public string? SiteNotes { get; set; }
}
