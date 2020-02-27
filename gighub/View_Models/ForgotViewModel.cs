using System.ComponentModel.DataAnnotations;

namespace gighub.View_Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}