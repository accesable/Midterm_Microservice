using hadilao.Models;
namespace hadilao.Helpers.Extensions;

public static class OrderExtensions
{
    public static IQueryable<OrderDto> ToOrderDtos(this IQueryable<Order> orders)
    {
        return orders.Select(o => new OrderDto
        {
            Id = o.Id,
            Price = o.Price,
            OrderTime = o.OrderTime,
            OrderDetails = o.OrderDetails.Select(od => new OrderDetailDto
            {
                Id = od.Id,
                DishId = od.DishId,
                Quantity = od.Quantity
                // Map other properties as needed
            }).ToList()
        });
    }
}
