
public class OrderDetailDto
{
    public int Id { get; set; } 
    public int? DishId { get; set; }
    public int? OrderId {get;set;}
    public int Quantity { get; set; }
    public string ? DishName {get;set;}
    // Include other properties you want to expose, but exclude navigation properties that cause cycles
}
