using System.ComponentModel.DataAnnotations;

namespace AzureApiApp.Models
{
    public class User
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
