using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDbLib.Models
{
    public class ChessDbContext : DbContext
    {
        //DbSets here
        public virtual DbSet<Player> Players { get; set; }

        public virtual DbSet<Tournament> Tournaments { get; set; }

        public virtual DbSet<Game> Games { get; set; }



        public ChessDbContext() { }
        public ChessDbContext(DbContextOptions<ChessDbContext> options) // what does this do?
            :base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                var connStr = "server=localhost\\sqlexpress;database=ChessTourDb;trusted_connection=true;";
                builder.UseSqlServer(connStr);
            }
        }
    }
}
