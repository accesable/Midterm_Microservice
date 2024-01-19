using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace hadilao.Models;
public class Order{
    [Key]
    public int Id {get;set;}
    public double Price {get;set;}

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DefaultValue(true)]
    public DateTime OrderTime {get;set;} = DateTime.UtcNow;
    public virtual ICollection<OrderDetail> ? OrderDetails {get;set;}

}