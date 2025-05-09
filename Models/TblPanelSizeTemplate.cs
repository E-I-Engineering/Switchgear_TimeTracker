using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_panel_size_template")]
public partial class TblPanelSizeTemplate
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ProjectID")]
    [StringLength(20)]
    public string? ProjectId { get; set; }

    [StringLength(10)]
    public string? PannelNumber { get; set; }

    public int? PanelSize { get; set; }
}
