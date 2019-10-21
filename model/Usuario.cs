using System.ComponentModel.DataAnnotations;

namespace netcore.model
{
    public class Usuario
    {
         [Required(ErrorMessage = "Campo Nombre es obligatorio"), StringLength (20)]
         [Display(Name = "Nombre ")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo clave es obligatorio"), StringLength (20)]
        public string Clave { get; set; }
        public string Mensaje { get; set; }
    }
}