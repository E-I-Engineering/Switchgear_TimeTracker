using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_checklist_transactions_data")]
public partial class TblChecklistTransactionsDatum
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("Transaction_Date", TypeName = "datetime")]
    public DateTime? TransactionDate { get; set; }

    [Column("Reason_Not_Completed")]
    public string? ReasonNotCompleted { get; set; }

    [StringLength(10)]
    public string? Status { get; set; }

    [Column("Checklist_transaction_ID")]
    public int? ChecklistTransactionId { get; set; }

    public string? Notes { get; set; }

    [Column("Template_TaskID")]
    public int? TemplateTaskId { get; set; }

    public string? Operators { get; set; }
}
