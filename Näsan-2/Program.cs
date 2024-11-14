// Punkt 1
string[] toys = ["Car", "Plane", "Doll", "Teddybear", "Lego"];

// Punkt 3
List<string> classmates = ["Linnea", "Amira", "Tea", "Aleks", "Ana"];

// Punkt 4
int[] numbers = new int[5] {1, 4, 5, 7, 9};

// Punkt 2 och 5
for (int i = 0; i < toys.Length; i++)
{
    Console.WriteLine($"{classmates[i]} gives the {toys[i]} the rate {numbers[i]}");   
}

// Punkt 6
List<string> cities = new();

// Punkt 7
string answer = "";
while (answer != "exit")
{
    Console.WriteLine("Please write a name of a city");
    answer = Console.ReadLine();
    cities.Add(answer);
}


Console.ReadLine();