using System.Buffers;

Car car = new Car("Toyota")
{
    Owner = "John"
};


class Car
{
    public string Owner { get; init; }
    public string Model { get; set; }
    public int Year { get;}
    public static int TotalCars { get; private set;}
    public Car()
    {

    }
    public Car(string model) : this()
    {
        Model = model;
        Year = 2020;
        TotalCars++;
    }
    public string Description => $"{Model} ({Year})";
}

class Character
{
    public required string Name { get; init; }
    public required string Class { get; init; }
    public int Experience { get; private set; } 
    public int Level { get 
        {
            if (Experience >= 1000) return 1;
            if (Experience >= 2000) return 2;
            if (Experience >= 3000) return 3;
            if (Experience >= 4000) return 4;
            if (Experience >= 5000) return 5;
            return 0;
        }
    }
    public void GainExperience(int experience)
    {
        Experience += experience;
    }

}