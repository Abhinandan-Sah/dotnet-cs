using System;
using System.Collections.Generic;

namespace M1_Practice
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }
    }

    public class HotelManager
    {
        public static List<Room> rooms = new List<Room>();

        public void AddRoom(int roomNumber, string type, double price)
        {
            foreach (var r in rooms)
            {
                if (r.RoomNumber == roomNumber)
                    return;
            }

            rooms.Add(new Room
            {
                RoomNumber = roomNumber,
                RoomType = type,
                PricePerNight = price,
                IsAvailable = true
            });
        }

        public Dictionary<string, List<Room>> GroupRoomsByType()
        {
            var dict = new Dictionary<string, List<Room>>();

            foreach (var room in rooms)
            {
                if (!dict.ContainsKey(room.RoomType))
                    dict[room.RoomType] = new List<Room>();

                dict[room.RoomType].Add(room);
            }

            return dict;
        }

        public bool BookRoom(int roomNumber, int nights, out int totalCost)
        {
            totalCost = 0;

            foreach (var room in rooms)
            {
                if (room.RoomNumber == roomNumber && room.IsAvailable)
                {
                    totalCost = (int)(nights * room.PricePerNight);
                    room.IsAvailable = false;
                    return true;
                }
            }
            return false;
        }

        public List<Room> GetAvailableRoomsByPriceRange(double min, double max)
        {
            List<Room> list = new List<Room>();

            foreach (var room in rooms)
            {
                if (room.IsAvailable && room.PricePerNight >= min && room.PricePerNight <= max)
                    list.Add(room);
            }
            return list;
        }

        public static void Main()
        {
            HotelManager hm = new HotelManager();

            hm.AddRoom(101, "Single", 1000);
            hm.AddRoom(102, "Double", 1500);
            hm.AddRoom(103, "Suite", 2000);

            int total;
            bool booked = hm.BookRoom(101, 2, out total);

            Console.WriteLine(booked ? $"Booked. Cost = {total}" : "Not available");
        }
    }
}
