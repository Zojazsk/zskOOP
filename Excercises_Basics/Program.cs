using System.Drawing;
Car c1 = new Car("Audi", "A6", 1998);
c1.DisplayInfo();
class Car(string brand, string model, int productionDate)
{
    public string Brand { get; private set; } = brand;
    public string Model { get; private set; } = model;
    public int ProductionDate { get; private set; } = productionDate;

    public void DisplayInfo()
    {
        System.Console.WriteLine("Brand: " + Brand);
        System.Console.WriteLine("Model: " + Model);
        System.Console.WriteLine("Productiondate: " + ProductionDate);
    }

}
