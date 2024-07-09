using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServiceStation.Web.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Full Name")]
        [StringLength(50)]
        [Required]
        public string? FullName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        public int Phone { get; set; }
        public bool IsDeleted { get; set; } = false;

        public List<Vehicle> Vehicles { get; set;} = new List<Vehicle>();
    }
}
