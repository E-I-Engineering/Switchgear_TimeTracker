using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Models;

[Keyless]
public partial class SwitchgearTest
{
    public int? Priority { get; set; }

    [Column("MAS Plan")]
    public DateOnly? MasPlan { get; set; }

    public int? Team { get; set; }

    [Column("Project # ENG")]
    [StringLength(50)]
    public string? ProjectEng { get; set; }

    [Column("Panel #")]
    [StringLength(50)]
    public string? Panel { get; set; }

    [Column("Panel  Discription")]
    [StringLength(255)]
    public string? PanelDiscription { get; set; }

    [Column("Start Date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("Ship Date", TypeName = "datetime")]
    public DateTime? ShipDate { get; set; }

    [Column("Production Completion Date", TypeName = "datetime")]
    public DateTime? ProductionCompletionDate { get; set; }

    [Column("SA Control Plan", TypeName = "datetime")]
    public DateTime? SaControlPlan { get; set; }

    [Column("SA Control Actual", TypeName = "datetime")]
    public DateTime? SaControlActual { get; set; }

    [Column("SA MCCB/SPD Fit Out Plan", TypeName = "datetime")]
    public DateTime? SaMccbSpdFitOutPlan { get; set; }

    [Column("SA MCCB/SPD Fit Out Actual", TypeName = "datetime")]
    public DateTime? SaMccbSpdFitOutActual { get; set; }

    [Column("SA Camlock Plan", TypeName = "datetime")]
    public DateTime? SaCamlockPlan { get; set; }

    [Column("SA Camlock Actual", TypeName = "datetime")]
    public DateTime? SaCamlockActual { get; set; }

    [Column("FA ACB Row Plan", TypeName = "datetime")]
    public DateTime? FaAcbRowPlan { get; set; }

    [Column("FA ACB Row Actual", TypeName = "datetime")]
    public DateTime? FaAcbRowActual { get; set; }

    [Column("FA Camlocks Plan", TypeName = "datetime")]
    public DateTime? FaCamlocksPlan { get; set; }

    [Column("FA Camlocks Actual", TypeName = "datetime")]
    public DateTime? FaCamlocksActual { get; set; }

    [Column("FA Flange Plan", TypeName = "datetime")]
    public DateTime? FaFlangePlan { get; set; }

    [Column("FA Flange Actual", TypeName = "datetime")]
    public DateTime? FaFlangeActual { get; set; }

    [Column("FA Control Doors 2nd Fix Plan", TypeName = "datetime")]
    public DateTime? FaControlDoors2ndFixPlan { get; set; }

    [Column("FA Control Doors 2nd Fix Actual", TypeName = "datetime")]
    public DateTime? FaControlDoors2ndFixActual { get; set; }

    [Column("FA Cable Access Plan", TypeName = "datetime")]
    public DateTime? FaCableAccessPlan { get; set; }

    [Column("FA Cable Access Actual", TypeName = "datetime")]
    public DateTime? FaCableAccessActual { get; set; }

    [Column("FA Interlinking Plan", TypeName = "datetime")]
    public DateTime? FaInterlinkingPlan { get; set; }

    [Column("FA Interlinking Actual", TypeName = "datetime")]
    public DateTime? FaInterlinkingActual { get; set; }

    [Column("FA MCCB/SPD 2nd Fix Plan", TypeName = "datetime")]
    public DateTime? FaMccbSpd2ndFixPlan { get; set; }

    [Column("FA MCCB/SPD 2nd Fix Actual", TypeName = "datetime")]
    public DateTime? FaMccbSpd2ndFixActual { get; set; }

    [Column("Misc Plan", TypeName = "datetime")]
    public DateTime? MiscPlan { get; set; }

    [Column("Misc Actual", TypeName = "datetime")]
    public DateTime? MiscActual { get; set; }

    [Column("FWT", TypeName = "datetime")]
    public DateTime? Fwt { get; set; }

    [Column("Production Comments")]
    public string? ProductionComments { get; set; }

    [Column("FA Dist Bd Plan", TypeName = "datetime")]
    public DateTime? FaDistBdPlan { get; set; }

    [Column("FA Dist Bd Actual", TypeName = "datetime")]
    public DateTime? FaDistBdActual { get; set; }

    [Column("FA TX Copper Plan", TypeName = "datetime")]
    public DateTime? FaTxCopperPlan { get; set; }

    [Column("FA TX Copper Actual", TypeName = "datetime")]
    public DateTime? FaTxCopperActual { get; set; }
}
