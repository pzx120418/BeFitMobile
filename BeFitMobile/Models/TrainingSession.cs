using SQLite;
using System;
using System.ComponentModel.DataAnnotations;

namespace BeFitMobile.Models
{
    public class TrainingSession
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required(ErrorMessage = "Data rozpoczęcia jest wymagana")]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "Data zakończenia jest wymagana")]
        public DateTime EndTime { get; set; }
    }
}
