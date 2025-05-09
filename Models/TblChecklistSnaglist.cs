using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_checklist_snaglist")]
public partial class TblChecklistSnaglist
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("AreaID")]
    public int? AreaId { get; set; }

    public string? SnagListItem { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [StringLength(50)]
    public string? Location { get; set; }
}
