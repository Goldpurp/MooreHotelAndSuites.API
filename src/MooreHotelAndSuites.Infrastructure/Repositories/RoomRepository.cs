using MooreHotelAndSuites.Domain.Entities;
using MooreHotelAndSuites.Domain.Interfaces;
using MooreHotelAndSuites.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MooreHotelAndSuites.Infrastructure.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly AppDbContext _db;
        public RoomRepository(AppDbContext db) => _db = db;
        public async Task AddAsync(Room room) { await _db.Rooms.AddAsync(room); await _db.SaveChangesAsync(); }
        public async Task<IEnumerable<Room>> GetAllAsync() => await _db.Rooms.ToListAsync();
        public async Task<Room?> GetByIdAsync(int id) => await _db.Rooms.FindAsync(id);
    }
}
