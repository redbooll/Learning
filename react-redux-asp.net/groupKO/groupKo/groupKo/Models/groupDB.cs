using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace groupKo.Models
{
    public class groupDB
    {
        [Key]
        [Column(Group = "nvarchar(100)")]
        public string TeamName { get; set; }
        
        [Column(Group = "nvarchar(100)")]
        public int GD { get; set; }

        [Column(Group = "nvarchar(100)")]
        public int PTS { get; set; }
    }
}
