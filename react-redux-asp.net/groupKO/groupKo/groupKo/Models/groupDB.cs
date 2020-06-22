using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace groupKo.Models
{
    public class groupDB
    {
        [Key]
        public string TeamName { get; set; }
        
        public int GD { get; set; }

        public int PTS { get; set; }
    }
}
