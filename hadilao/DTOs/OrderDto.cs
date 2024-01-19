public class OrderDto
{
    public int Id { get; set; }
    public double Price { get; set; }
    public DateTime OrderTime { get; set; }
    public List<OrderDetailDto> ? OrderDetails { get; set; }
}

