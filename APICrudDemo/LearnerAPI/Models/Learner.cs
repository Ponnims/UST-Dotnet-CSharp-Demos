using System.ComponentModel.DataAnnotations;

namespace LearnerAPI.Models
{
    public class Learner
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; } = "";
        [Required(ErrorMessage = "Stream is required")]
        public string? Stream { get; set; } = "";
        [Required(ErrorMessage = "Score is required")]
        public int Score { get; set; }

    }
}
