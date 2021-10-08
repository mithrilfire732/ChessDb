using ChessDbLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ChessDbLib.Controllers
{
    public  class PlayerControllers
    {
        private readonly ChessDbContext _context;

        public PlayerControllers()
        {
            _context = new ChessDbContext();
        }

        public async Task<List<Player>> GetAll()
        {
            return await _context.Players.OrderByDescending(x => x.Elo).ToListAsync();
        }

        public async Task<Player> GetByPk(int Id)
        {
            return await _context.Players.FindAsync(Id);
        }

        public async void Create(Player player)
        {
            player.Id = 0;
            await _context.Players.AddAsync(player);
            var rowsAffected = _context.SaveChangesAsync().Result;
            if(rowsAffected != 1)
            {
                throw new Exception("Create failed!");
            }
        }

        public async void Change(int Id, Player player)
        {
            _context.Players.
        }
    }
}
