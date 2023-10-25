using System.ComponentModel.DataAnnotations;

namespace JaverVarela_ExamenP1.Models
{
    public class JavierVarela_tabla
    {
        [Key]
        public int JVId { get; set; }

        [StringLength(20,ErrorMessage = "Deben haber al menos 20 caracteres")]
        public string JVDescripcion { get; set; }

        [Required(ErrorMessage = "Debe estar en el rango de 0 a 20")]
        [Range(0,20)]
        public decimal JVNota { get; set; }

        [Required]
        public bool JVIsTrue { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime JVFecha { get; set; }
    }
}
