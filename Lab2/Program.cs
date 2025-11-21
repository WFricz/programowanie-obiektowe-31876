Car car1 = new Car("Audi", 2023);
Car car2 = new Car("VW", 1998);
Car car3 = new Car("Fiat", 2011);

car1.ShowMe();
car2.ShowMe();
car3.ShowMe();
var bike1 = new Bike();

StartAnyVehicle(bike1);
StartAnyVehicle(car2);

void StartAnyVehicle(Vehicle vehicle)
{
    vehicle.Start();
}

Console.Write(car1.Model);

class Vehicle
{
    public double EngineCapacity { get; protected set; }

    public void Start()
    {
        Console.WriteLine("Vehicle Started");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle Stopped");
    }
}

class Bike : Vehicle
{
}

class Car : Vehicle
{
    private string model;
    private int year;


    public string Model => model;
    // {
    //     get { return model; }
    // }
    public int Year
    {
        get { return year; }
        // set
        // {
        //     if (value < 2000)
        //     {
        //         throw new Exception("Your car is too old");
        //     }
        //
        //     year = value;
        // }
    }

    public Car(string model, int year)
    {
        this.model = model;
        this.year = year;
    }

    public void ShowMe()
    {
        Console.WriteLine($"Model: {model},  Year: {year}");
    }
}
// Zadanie 5
class KontoBankowe
{
    private double saldo;
    public void Wplata(double kwota) { saldo += kwota; }
    public void Wyplata(double kwota) { saldo -= kwota; }
    public double PobierzSaldo() { return saldo; }
}
// Zadanie 6
class Zwierze
{
    public void Jedz() => Console.WriteLine("Zwierzę je");
}
class Pies : Zwierze
{
    public void Szczekaj() => Console.WriteLine("Hau hau!");
}

class Kot : Zwierze
{
    public void Miaucz() => Console.WriteLine("Miau miau!");
}