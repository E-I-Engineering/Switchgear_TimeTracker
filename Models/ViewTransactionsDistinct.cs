using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
public partial class ViewTransactionsDistinct
{
    [Column("MATR_SEQ_NO")]
    public string? MatrSeqNo { get; set; }

    [Column("editDate", TypeName = "datetime")]
    public DateTime? EditDate { get; set; }

    [Column("Production_Status")]
    public bool? ProductionStatus { get; set; }
}
