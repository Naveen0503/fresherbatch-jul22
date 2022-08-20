using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment_1.Models
{
    [Table("FOOTBALL_LEAGUE")]
    public class FOOTBALL_LEAGUE
    {
        [Range(1001, 10000)]
        public int MatchID { get; set; }
        [Required]
        public string TeamName1 { get; set; }
        [Required]
        public string TeamName2 { get; set; }
        [Required]
        public string Status { get; set; }
        
        public string WinningTeam { get; set; }
        [Range(2,4)]
        [Required]
        public int points { get; set; }
    }
}