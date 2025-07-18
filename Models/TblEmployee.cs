﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_Employees")]
[Index("Email", Name = "email_unique", IsUnique = true)]
[Index("Email", Name = "unique_email", IsUnique = true)]
[Index("TagNo", Name = "unique_tag", IsUnique = true)]
public partial class TblEmployee
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string FullName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; }

    public int? ClockNumber { get; set; }

    [Required]
    [StringLength(100)]
    [Unicode(false)]
    public string TagNo { get; set; }

    [Column("SupervisorID")]
    public int? SupervisorId { get; set; }

    [ForeignKey("SupervisorId")]
    [InverseProperty("TblEmployees")]
    public virtual TblSupervisor Supervisor { get; set; }

    [InverseProperty("User")]
    public virtual List<TblLaborTimeStamp> TblLaborTimeStamps { get; set; }
}