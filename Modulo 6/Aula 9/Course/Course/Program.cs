using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            People[] rooms = new People[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                rooms[room-1] = new People { Name = name, Email = email };
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++) {
                if (rooms[i] != null) {
                    Console.WriteLine($"{i+1}: {rooms[i]}");
                }
            }
        }
    }
}
