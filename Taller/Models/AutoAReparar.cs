using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.Models
{
    public class AutoAReparar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor ingrese una patente"), MaxLength(8, ErrorMessage = "Ingrese una patente válida")]
        public string Patente { get; set; }
        [Required(ErrorMessage = "Por favor ingrese una marca")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un modelo")]
        public string Modelo { get; set; }
        

    }
}
