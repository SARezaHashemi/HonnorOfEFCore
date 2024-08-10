namespace HonorOfEFCore.Models;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime JoiningTime { get; set; }

    //Here u can add some Regex attributes for checking correct Email And Phone
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public ICollection<Factor> Factors { get; set; } = new List<Factor>();

}