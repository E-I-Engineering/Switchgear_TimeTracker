using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_transactions_pictures")]
public partial class TblTransactionsPicture
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("Image_ID")]
    public string? ImageId { get; set; }

    [Column("Created_Date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("URL_src")]
    public string? UrlSrc { get; set; }

    [Column("Upload_Status")]
    [StringLength(10)]
    public string? UploadStatus { get; set; }

    [Column("Uploaded_by")]
    public string UploadedBy { get; set; } = null!;

    [Column("Transaction_ID")]
    public int? TransactionId { get; set; }

    public string? Path { get; set; }

    [Column("isDraw")]
    public bool? IsDraw { get; set; }
}
