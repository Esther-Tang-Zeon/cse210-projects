public class House
{
    public List<Room> _rooms { get; private set; } = new List<Room>();

    public void AddRoom(Room room)
    {
        Rooms.Add(room);
    }
}