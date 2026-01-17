using System.ComponentModel.DataAnnotations;
using SQLite;

namespace BeFitMobile.Models
{
    public class ExerciseInSession
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required]
        public int ExerciseTypeId { get; set; }

        [Required]
        public int TrainingSessionId { get; set; }

        [Range(0, 500)]
        public double Weight { get; set; }

        [Range(1, 20)]
        public int Sets { get; set; }

        [Range(1, 100)]
        public int Repetitions { get; set; }
    }
}
