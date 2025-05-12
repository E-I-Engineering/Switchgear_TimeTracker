using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace Switchgear_TimeTracker.Models;

[Table("tbl_labor_time_stamps")]
public partial class TblLaborTimeStamp
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Column("ProjectID")]
    public int ProjectId { get; set; }

    [Column("ClockIN", TypeName = "datetime")]
    public DateTime ClockIn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClockOut { get; set; }

    [ForeignKey("ProjectId")]
    [InverseProperty("TblLaborTimeStamps")]
    public virtual TblProject Project { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("TblLaborTimeStamp")]
    public virtual TblEmployee User { get; set; } = null!;

    string connectionString = "Data Source=SCSQL01;Initial Catalog=us_switchgear;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

    //public TblLaborTimeStamp
}
