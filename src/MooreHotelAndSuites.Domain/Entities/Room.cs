namespace MooreHotelAndSuites.Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public Hotel? Hotel { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
