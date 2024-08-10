namespace HonorOfEFCore.Models;

public class Product
{
    public int Id {get;set;}
    public string Name { get; set; } = String.Empty;
    public DateTime SharedDate { get; set; }
    public long Count { get; set; }
    public double Cost { get; set; }

    //Any other shit u want
}