using hadilao.Models;
namespace hadilao.Helpers.Extensions;

public static class OrderDetailExtensions
{
    public static IQueryable<OrderDetailDto> ToOrderDetailDtos(this IQueryable<OrderDetail> orderDetails)
    {
        return orderDetails.Select(o=> new OrderDetailDto
        {
            Id = o.Id,
            DishId = o.DishId,
            Quantity = o.Quantity,
            OrderId = o.OrderId,
            DishName = o.Dish.Name
        });
    }
}
