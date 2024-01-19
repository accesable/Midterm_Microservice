using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hadilao.Models;
public class OrderDetail{
    [Key]
    public int Id {get;set;}
    public int? DishId {get;set;}
    public int? OrderId {get;set;}

    [ForeignKey("DishId")]
    public Dish ? Dish {get;set;}
    [ForeignKey("OrderId")]
    public Order ? Order {get;set;}
    public int Quantity {get;set;}
}