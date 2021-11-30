using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCar.Models
{
    public class Car
    {

        public int Id { get; set; }

        [StringLength(20, MinimumLength = 2)]
        [Required]
        public string Mark { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [Display(Name = "YearOfProduction")]
        [DataType(DataType.Date)]
        public DateTime YearOfProduction { get; set; }

        [Range(1,999999999)]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

    }
}
