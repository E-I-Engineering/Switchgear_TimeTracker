using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_people")]
public partial class TblPerson
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    [Column("Amount_of_people")]
    public int? AmountOfPeople { get; set; }

    [Column("Target_amount_of_people")]
    public int? TargetAmountOfPeople { get; set; }

    [StringLength(255)]
    public string? Notes { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? FormatedDate { get; set; }
}
