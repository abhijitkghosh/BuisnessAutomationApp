using System.ComponentModel.DataAnnotations;

namespace BuisnessAutomation.Models.EntityModels
{
    public class Customer
    {
        public int Id { get; set; }
        public string name { get; set; } 
        public string phone { get; set; }
        //? dewar mane holo nullable hote pare
        public string? Email { get; set; }
        public string? Address { get; set; }
        //public string CustomerType {get; set; }
    }
}
