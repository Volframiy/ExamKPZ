using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.DataModels
{
    public class LaboratoryWorks
    {
        [Required]
        public int Id { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public DateTime Time { get; set; }
        public string Model { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }
    }
}
