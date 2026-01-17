using System.ComponentModel.DataAnnotations;

namespace BeFitMobile.Models
{
    public class ExerciseInSession
    {
        public int Id { get; set; }

        [Required]
        public int ExerciseTypeId { get; set; }

        [Required]
        public int TrainingSessionId { get; set; }

        [Range(0, 500, ErrorMessage = "Obciążenie musi być między 0 a 500 kg")]
        public double Weight { get; set; }

        [Range(1, 20, ErrorMessage = "Liczba serii musi być między 1 a 20")]
        public int Sets { get; set; }

        [Range(1, 100, ErrorMessage = "Liczba powtórzeń musi być między 1 a 100")]
        public int Repetitions { get; set; }
    }
}
