using System;

class Car
{
    public string Driver { get; set; }
    public int Speed { get; set; }
}

class FormulaOneRace
{
    static void Main()
    {
        Console.WriteLine("Formula One Racing Simulation");


        Car car1 = new Car { Driver = "Lewis Hamilton", Speed = 0 };
        Car car2 = new Car { Driver = "Max Verstappen", Speed = 0 };

        Console.WriteLine($"Cars on the track: {car1.Driver} and {car2.Driver}");


        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\nRace Lap {i}");


            car1.Speed += GetRandomSpeedChange();
            car2.Speed += GetRandomSpeedChange();


            DisplayRaceProgress(car1, car2);

            System.Threading.Thread.Sleep(1000);
        }

        Console.WriteLine("\nRace Finished!");
    }

    static void DisplayRaceProgress(Car car1, Car car2)
    {
        Console.WriteLine($"{car1.Driver}: {car1.Speed} km/h");
        Console.WriteLine($"{car2.Driver}: {car2.Speed} km/h");

        string leader = car1.Speed > car2.Speed ? car1.Driver : car2.Driver;
        Console.WriteLine($"Leader: {leader}");
    }

    static int GetRandomSpeedChange()
    {

        Random random = new Random();
        return random.Next(-5, 10);
    }
}
