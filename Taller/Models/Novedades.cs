using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.Models
{
    public class Novedades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el id del empleado"), Range(1, int.MaxValue, ErrorMessage = "Por favor ingrese un numero valido")]
        public int IdEmpleado { get; set; }
        [Required(ErrorMessage = "Por favor ingrese una patente"), MaxLength(8, ErrorMessage = "Ingrese una patente válida")]
        public string Patente { get; set; }
        [Required]
        [EnumDataType(typeof(Estado))]
        public Estado Estado { get; set; }


    }
}
