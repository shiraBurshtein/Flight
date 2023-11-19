using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Model.Model
{
    [Table("FlightCompany")]
    public class FlightCompany
    {
        [Key]
        [Required]
        public int Code { get; set; }
        [Required]
        public string Name { get; set; }
        public int CodeManager { get; set; }
        public double Stars { get; set; }
      
    }
}
