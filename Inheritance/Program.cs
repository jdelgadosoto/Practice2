
var vehicles = new List<Vehicle>()
{
    new Car(),
    new Motorcycle()
};

foreach (var vehicle in vehicles)
{
    var engine = vehicle.StartEngine();
    Console.WriteLine(engine);
}

public class Vehicle
{
    public virtual string Make => "Some brand";
    public virtual string Model => "Some model";
    public virtual int Year => 0000;

    public virtual string Details()
    {
        return $"Make: {Make}\n Model: {Model}\n Year: {Year}";
    }

    public virtual string StartEngine()
    {
        return "Start the engine";
    }
}

public class Car : Vehicle
{
    public override string Make => "Toyota";
    public override string Model => "Corolla";
    public override int Year => 2016;
    public int Seats => 4;

   
    public override string Details()
    {
        return $"Make: {Make}\n Model: {Model}\n Year: {Year}\n Number of seats: {Seats}";
    }

    public override string StartEngine()
    {
        return "Start the engine by pressing the breaks pedal and turning the key";
    }
}

public class Motorcycle : Vehicle
{
    public override string Make => "Harley Davison";
    public override string Model => "Freewheeler";
    public override int Year => 2024;

    public int Helmets = 1;
   

    public override string Details()
    {
        return $"Make: {Make}\n Model: {Model}\n Year: {Year}\n Number of helmets: {Helmets}";
    }

    public override string StartEngine()
    {
        return "Start the engine by turning ON the fuel petcock, squeeze the motorcycle clutch lever and press the start button";
    }
}