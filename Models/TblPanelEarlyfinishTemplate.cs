using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_panel_earlyfinish_template")]
public partial class TblPanelEarlyfinishTemplate
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ActivityID")]
    [StringLength(50)]
    public string? ActivityId { get; set; }

    [StringLength(50)]
    public string? ActivityDescription { get; set; }

    public int? EarlyFinishDate { get; set; }

    [StringLength(50)]
    public string? PanelSizeDesc { get; set; }

    public int? PanelSize { get; set; }

    [Column("isBatch")]
    public int? IsBatch { get; set; }
}
