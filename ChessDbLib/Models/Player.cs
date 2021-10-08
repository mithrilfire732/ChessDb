using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDbLib.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string  Lastname { get; set; }
        public int Elo { get; set; }
        public string Nationality { get; set; }

        public Player() { }
    }
}
