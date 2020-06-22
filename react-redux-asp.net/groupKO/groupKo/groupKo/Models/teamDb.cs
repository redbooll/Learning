using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace groupKo.Models
{
    public class teamDb
    {
        [Key]
        [Column(RegisteredTeam = "nvarchar(100)")]
        public string TeamName { get; set; }
    }
}
