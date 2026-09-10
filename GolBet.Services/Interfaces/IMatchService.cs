using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GolBet.Entities.Enums;

using GolBet.Services.DTOs;
namespace GolBet.Services.Interfaces;
public interface IMatchService
{
    /// <summary>Match board: all active matches ordered by date.</summary> 
    Task<IEnumerable<MatchDto>> GetBoardAsync(MatchStatus? status = null);

}
