using System.ComponentModel.DataAnnotations;
using SQLite;

namespace BeFitMobile.Models
{
    public class ExerciseType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa ćwiczenia jest wymagana")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nazwa musi mieć od 3 do 50 znaków")]
        public string Name { get; set; }
    }
}
