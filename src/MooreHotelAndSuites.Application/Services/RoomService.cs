using MooreHotelAndSuites.Domain.Entities;
using MooreHotelAndSuites.Domain.Interfaces;
namespace MooreHotelAndSuites.Application.Services
{
    public class RoomService
    {
        private readonly IRoomRepository _repo;
        public RoomService(IRoomRepository repo) => _repo = repo;
        public Task<IEnumerable<Room>> GetAllAsync() => _repo.GetAllAsync();
        public Task<Room?> GetAsync(int id) => _repo.GetByIdAsync(id);
        public Task CreateAsync(Room r) => _repo.AddAsync(r);
    }
}
