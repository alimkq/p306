using System;

class Aircraft
{
    private string model;
    private int altitude;
    private int speed;

    public Aircraft(string model)
    {
        this.model = model;
        altitude = 0;
        speed = 0;
    }

    public void TakeOff(int desiredAltitude)
    {
        if (altitude == 0)
        {
            Console.WriteLine($"Aircraft {model} is taking off...");
            altitude = desiredAltitude;
            Console.WriteLine($"Aircraft {model} is at an altitude of {altitude} meters.");
        }
        else
        {
            Console.WriteLine($"Aircraft {model} is already in the air at an altitude of {altitude} meters.");
        }
    }

    public void Land()
    {
        if (altitude > 0)
        {
            Console.WriteLine($"Aircraft {model} is landing...");
            altitude = 0;
            speed = 0;
            Console.WriteLine($"Aircraft {model} has successfully landed.");
        }
        else
        {
            Console.WriteLine($"Aircraft {model} is already on the ground.");
        }
    }

    public void IncreaseAltitude(int height)
    {
        if (altitude > 0)
        {
            altitude += height;
            Console.WriteLine($"Aircraft {model} has climbed to an altitude of {altitude} meters.");
        }
        else
        {
            Console.WriteLine($"Aircraft {model} is on the ground. Please take off first.");
        }
    }

    public void DecreaseAltitude(int height)
    {
        if (altitude > 0)
        {
            if (altitude - height >= 0)
            {
                altitude -= height;
                Console.WriteLine($"Aircraft {model} has descended to an altitude of {altitude} meters.");
            }
            else
            {
                Console.WriteLine($"Aircraft {model} cannot descend below ground level.");
            }
        }
        else
        {
            Console.WriteLine($"Aircraft {model} is on the ground.");
        }
    }

    public void IncreaseSpeed(int speedValue)
    {
        speed += speedValue;
        Console.WriteLine($"Aircraft {model} has increased its speed to {speed} km/h.");
    }

    public void DecreaseSpeed(int speedValue)
    {
        if (speed - speedValue >= 0)
        {
            speed -= speedValue;
            Console.WriteLine($"Aircraft {model} has decreased its speed to {speed} km/h.");
        }
        else
        {
            Console.WriteLine($"Aircraft {model} cannot move at a negative speed.");
        }
    }
}

class Program
{
    static void Main()
    {
        Aircraft aircraft = new Aircraft("Boeing 747");
        aircraft.TakeOff(10000);
        aircraft.IncreaseAltitude(5000);
        aircraft.DecreaseAltitude(2000);
        aircraft.IncreaseSpeed(100);
        aircraft.DecreaseSpeed(50);
        aircraft.Land();
    }
}

