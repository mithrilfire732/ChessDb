using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDbLib.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public int PlayerIdWhite { get; set; }
        public int PlayerIdBlack { get; set; }
        public bool WhiteWins { get; set; }
        public bool BlackWins { get; set; }

        public virtual Player WhitePlayer { get; set; }
        public virtual Player BlackPlayer { get; set; }
        public virtual Tournament Tournament { get; set; }

        public Game() {
        if(WhiteWins ==true && BlackWins == true)
            {
                throw new Exception("WhiteWins and BlackWins set to true. Only one player may win-to indicate a draw set both to false");
            }
        }
    }
}
