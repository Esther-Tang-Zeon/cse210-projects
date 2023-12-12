using System;

class Program
{
    static void Main(string[] args)
    {     
        House myHouse = new House();

        Room livingRoom = new Room("Living Room");
        livingRoom.AddDevice(new SmartDevice("Smart TV"));
        livingRoom.AddDevice(new SmartDevice("Smart Light"));

        myHouse.AddRoom(livingRoom);

        // Example usage
        livingRoom.TurnOnAllDevices();
        livingRoom.ReportAllDevicesStatus();
        livingRoom.TurnOffAllDevices();

    }
}