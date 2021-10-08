using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDbLib.Models
{
    public class ChessDbContext :DbContext
    {
        //DbSets here
        
        
        public override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Player>
        }
    }
}
