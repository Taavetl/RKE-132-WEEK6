string[] snacks = { "sushi", "pizza", "pizza", "burger", "chicken" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"me votame {snacks[randomIndex]}.");

