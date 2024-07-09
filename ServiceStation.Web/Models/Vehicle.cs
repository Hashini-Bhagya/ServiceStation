


using System.ComponentModel.DataAnnotations;

namespace ServiceStation.Web.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        public string? Make { get; set; }

        [Required]
        public string? Model { get; set; }

        [Required]
        public int Year { get; set; }

        public string? Color { get; set; }

        public bool IsDeleted { get; set; } = false;

        [Required(ErrorMessage = "The Customer field is required.")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
