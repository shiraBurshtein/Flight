using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Model.Model
{
    [Table("Passenger")]
    public class Passenger
    {
        [Key]
        [Required]
        public int Code { get; set; }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Phone { get; set; }
        [ForeignKey(nameof(CodeFlighting))]
        public int CodeFlighting { get; set; }

    }
}
