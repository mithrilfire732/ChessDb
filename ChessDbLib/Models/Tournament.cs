using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDbLib.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(40)]
        public string Location { get; set; }
        public DateTime Date { get; set; }

        public Tournament() { }
    }
}
