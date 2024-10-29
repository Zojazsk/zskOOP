
Desk d1 = new Desk("red", "Nivea");

Console.WriteLine(d1.Height);

while(true)
{
    d1.Lift();
    Thread.Sleep(500);
}

//Constructor primary
class Desk(string color, string brand)
{
    public const decimal MAX_HEIGHT = 2.0m;
    public decimal Height { get; private set; } = 1.0m;
    public string Color { get; private set; } = color;
    public string Brand { get; private set; } = brand;

    //Constructor (style 1)

    //public Desk(int height, string color, string brand)
    //{
    //    this.height = height;
    //    this.color = color;
    //    this.brand = brand;
    //}
    
    public decimal getHeight()
    {
        return Height;
    }
    public void Lift()
    {
        if (Height < MAX_HEIGHT)
        {
            Height += 0.1m;
        } else
        {
            Console.WriteLine($"Hey, it's too high. Max {MAX_HEIGHT}");
        }
        Console.WriteLine($"Desk is on {Height} height");
    }
}


// public, private, protected

