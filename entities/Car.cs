

public class Car
{
    public int Id { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public string? Motorizare { get; set; }
    public int Hp { get; set; }

    public double Price {get; set;}

    public Car(int id, string brand, string model, string motorizare, int hp, double price)
    {
        Id = id;
        Brand = brand;
        Model = model;
        Motorizare = motorizare;
        Hp = hp;
        Price = price;
    }



}