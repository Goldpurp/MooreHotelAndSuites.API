using MooreHotelAndSuites.Domain.Entities;

namespace MooreHotelAndSuites.Domain.Interfaces
{
    public interface IRoomRepository
    {
        Task<Room?> GetByIdAsync(int id);
        Task<IEnumerable<Room>> GetAllAsync();
        Task AddAsync(Room room);
    }
}
