using System.ComponentModel.DataAnnotations;

namespace netcore.model {
    public class Form {
        [Required(ErrorMessage = "Campo nombre es obligatorio"), StringLength (20)]
         [Display(Name = "Nombre ")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo apellido es obligatorio"), StringLength (20)]
        public string Apellido { get; set; }

        [Required (ErrorMessage = "Campo correo es obligatorio"), StringLength (100)]
        [EmailAddress(ErrorMessage = "No cumple con formato de correo")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Campo dirección es obligatorio"), StringLength (50)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Campo observación es obligatorio"), StringLength (100)]
        public string Observacion { get; set; }

    }
}