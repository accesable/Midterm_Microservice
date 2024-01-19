using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;

namespace hadilao.Models;
public class Dish{
    [Key]
    public int Id {get;set;}
    [StringLength(100)]
    [Required]
    public string ? Name {get;set;}
    public double Price {get;set;}

}

public static class DishEndpoints
{
	public static void MapDishEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Dish");

        group.MapGet("/", () =>
        {
            return new [] { new Dish() };
        })
        .WithName("GetAllDishes");

        group.MapGet("/{id}", (int id) =>
        {
            //return new Dish { ID = id };
        })
        .WithName("GetDishById");

        group.MapPut("/{id}", (int id, Dish input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdateDish");

        group.MapPost("/", (Dish model) =>
        {
            //return TypedResults.Created($"/api/Dishes/{model.ID}", model);
        })
        .WithName("CreateDish");

        group.MapDelete("/{id}", (int id) =>
        {
            //return TypedResults.Ok(new Dish { ID = id });
        })
        .WithName("DeleteDish");
    }
}