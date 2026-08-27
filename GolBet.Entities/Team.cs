using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

using GolBet.Entities.Common;



namespace GolBet.Entities;

public class Team : AuditableEntity
{
    [Required, MaxLength(80)]
    public string Name { get; set; } = null!;
    [Required, MaxLength(60)]
    public string City { get; set; } = null!;
    [MaxLength(300)]
    public string? CrestUrl { get; set; }
}
