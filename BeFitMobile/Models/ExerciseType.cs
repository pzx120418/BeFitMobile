using SQLite;
using System.ComponentModel.DataAnnotations;

namespace BeFitMobile.Models
{
    public class ExerciseType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Category { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
