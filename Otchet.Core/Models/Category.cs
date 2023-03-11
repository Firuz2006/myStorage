namespace Otchet.Core.Models;

public class Category:EntityBase
{
    public string Name { get; set; }
    public List<Product> Products { get; set; }
    public override string ToString()=> Name;
    
}