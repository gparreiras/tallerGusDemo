using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tallerGusDemo.Models
{
    [Table("d_car")]
    public class Car
    {
        [Key]
        public int CarID        { get; set; }

        [Required(ErrorMessage = "Enter Make")]
        public string Make      { get; set; }

        [Required(ErrorMessage = "Enter Model")]
        public string Model     { get; set; }

        [Required(ErrorMessage = "Enter Year")]
        public int Year         { get; set; }

        [Required(ErrorMessage = "Enter Doors")]
        public int Doors        { get; set; }

        [Required(ErrorMessage = "Enter Color")]
        public string Color     { get; set; }

        [Required(ErrorMessage = "Enter Price")]
        public int Price        { get; set; }
        
        public int? PriceGuess  { get; set; }
        
    }
}
