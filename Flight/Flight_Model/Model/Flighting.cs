using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Model.Model
{
    [Table("Flighting")]
    public class Flighting
    {
        [Key]
        [Required]
        public int Code { get; set; }
        [ForeignKey(nameof(CodeCompany))]
        public int CodeCompany { get; set; }
        [ForeignKey(nameof(CodePilot))]
        public int CodePilot { get; set; }
        public DateTime DateTime { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int Seats { get; set; }
        public int NumOfPassengers { get; set; }
    }
}
