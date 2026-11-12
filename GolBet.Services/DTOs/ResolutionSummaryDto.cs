using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolBet.Services.DTOs;



/// <summary>What happened when a match was closed. For the Admin's feedback.</summary> 

public class ResolutionSummaryDto

{

    public int ResolvedBets { get; set; }

    public int WonBets { get; set; }

    public decimal TotalPaid { get; set; }

}