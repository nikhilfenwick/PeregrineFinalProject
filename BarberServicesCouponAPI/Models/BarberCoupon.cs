using System.ComponentModel.DataAnnotations;

namespace BarberServicesCouponAPI.Models
{
    public class BarberCoupon
    {
        [Key]
        public int BarberCouponId { get; set; }
        [Required]
        public string BarberCouponCode { get; set; }
        [Required]
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}