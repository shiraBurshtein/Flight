using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Model.Model
{
    [Table("Pilot")]
    public class Pilot
    {
        [Key]
        [Required]
        public int code { get; set; }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey(nameof(CodeCompany))]
        public int CodeCompany { get; set; }
        public int Phone { get; set; }
    }
}
