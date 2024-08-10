namespace HonorOfEFCore.Models;

public class FactorItem
{
    public int Id { get; set; }
    public int Count { get; set; }
    public int FactorId { get; set; }
    public virtual Factor Factor { get; set; }

    public int ProductId { get; set; }
    public virtual Product Product { get; set; }

}