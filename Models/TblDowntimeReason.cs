﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_downtime_Reasons")]
public partial class TblDowntimeReason
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(75)]
    [Unicode(false)]
    public string Text { get; set; }

    [InverseProperty("DowntimeReason")]
    public virtual ICollection<TblLaborTimeStamp> TblLaborTimeStamps { get; set; } = new List<TblLaborTimeStamp>();
}