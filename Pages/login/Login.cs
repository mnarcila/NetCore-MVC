using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using netcore.model;
namespace netcore.Pages.login {
    public class Login : PageModel {
        public const string SessionKeyName = "_Name";
        
        public IActionResult OnGet () {
            return Page ();
        }

        [BindProperty]
        public Usuario usuario { get; set; }
        public async Task<IActionResult> OnPostAsync () {
            if (!ModelState.IsValid) {
                Console.WriteLine ("Entro1");
                return Page ();
            } else {
                Console.WriteLine ("Entro2");

                if (usuario.Nombre.Equals ("admin") && usuario.Clave.Equals ("admin")) {

                    if (string.IsNullOrEmpty (HttpContext.Session.GetString (SessionKeyName))) {
                        HttpContext.Session.SetString (SessionKeyName, usuario.Nombre);

                    }
                    return RedirectToPage ("../home/Home");
                } else {
                    usuario.Mensaje = "Usuario o clave incorrecto";
                    return Page ();
                }
            } 
        }
    }

}