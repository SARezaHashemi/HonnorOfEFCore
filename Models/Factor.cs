namespace HonorOfEFCore.Models;

public class Factor
{
    public int Id { get; set; }
    public DateTime FactorDate { get; set; }
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
    public ICollection<FactorItem> FactorItems { get; set; } = new List<FactorItem>();

    //Make this method async for better performance
    public double getSum(){
        return this.FactorItems.Sum(fi => fi.Count*fi.Product.Cost);
    }


}