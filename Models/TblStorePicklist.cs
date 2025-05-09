using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
[Table("tbl_store_picklist")]
public partial class TblStorePicklist
{
    [Column("PicklistID")]
    public int PicklistId { get; set; }

    public int? PickerNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateCreated { get; set; }

    public int? ReceiverNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateReceived { get; set; }

    [Column("ProjectID")]
    [StringLength(50)]
    public string? ProjectId { get; set; }

    public string? ProjectName { get; set; }

    [StringLength(50)]
    public string? Panel { get; set; }

    [StringLength(50)]
    public string? Area { get; set; }

    [Column("Team_Number")]
    [StringLength(50)]
    public string? TeamNumber { get; set; }
}
