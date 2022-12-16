using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.DataModels
{
    public class Students
    {
        [Required]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string GroupName { get; set; }
    }
}
