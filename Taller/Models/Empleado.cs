using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.Models
{
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un apellido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un dni"), Range(10000000, 99999999, ErrorMessage = "Ingrese un dni válido")]
        public int Dni { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un telefono"), DataType(DataType.PhoneNumber, ErrorMessage = "Ingrese un telefono válido")]
        public int Telefono { get; set; }
        
        
    }
}
