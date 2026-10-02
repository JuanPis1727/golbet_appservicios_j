using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolBet.Services.DTOs
{
    public class TeamDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string City { get; set; } = null!;
        public string? CrestUrl { get; set; }
        public bool IsActive { get; set; }

    }
}
