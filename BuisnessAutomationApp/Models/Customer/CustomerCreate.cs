using System.ComponentModel.DataAnnotations;

namespace BuisnessAutomationApp.Models.Customer
{
    public class CustomerCreate
    {
        [Required]
        public string name { get; set; }

        [Required]
        public string phone { get; set; }
        //? dewar mane holo nullable hote pare
        public string? Email { get; set; }
    }
}
