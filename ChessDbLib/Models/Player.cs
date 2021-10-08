using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDbLib.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(30)]
        public string  Lastname { get; set; }
        public int Elo { get; set; }
        [Required]
        [StringLength(40)]
        public string Nationality { get; set; }

        public Player() { }
    }
}
