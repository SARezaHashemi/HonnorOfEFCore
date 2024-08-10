namespace HonorOfEFCore.Models;

public class Factor
{
    public int Id { get; set; }
    public DateTime FactorDate { get; set; }
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
    public ICollection<FactorItem> factorItems { get; set; } = new List<FactorItem>();
}