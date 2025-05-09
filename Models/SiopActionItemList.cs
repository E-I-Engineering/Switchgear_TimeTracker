using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("SIOP Action Item List")]
public partial class SiopActionItemList
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("Date Entered")]
    public DateOnly? DateEntered { get; set; }

    public string? Action { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Status { get; set; }

    public string? Assigned { get; set; }

    [Column("Due Date")]
    public DateOnly? DueDate { get; set; }

    [Column("Date Closed")]
    public DateOnly? DateClosed { get; set; }

    public string? Comments { get; set; }
}
