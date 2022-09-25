using System.ComponentModel.DataAnnotations;

namespace GroceryDelivery.Models
{
    public class Order
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        [StringLength(30)]
        [Required]
        public string FirstName {get; set;} = string.Empty;

        [Display(Name = "Last Name")]
        [StringLength(30)]
        [Required]
        public string LastName {get; set;} = string.Empty;

        [Display(Name = "Address")]
        [StringLength(30)]
        [Required]
        public string Address {get;set;} = string.Empty;

        [Display(Name = "Items to Purchase")]
        [Required]
        public string Items {get;set;} = string.Empty;

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }


    }
}