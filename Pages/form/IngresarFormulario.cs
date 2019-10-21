using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using netcore.model;

namespace netcore.Pages.form {
    public class IngresarFormulario : PageModel {
        public const string SessionKeyName = "_Name";
        public IActionResult OnGet () {
            if (string.IsNullOrEmpty (HttpContext.Session.GetString (SessionKeyName))) {
                return RedirectToPage ("../login/Login");
            } else {
                return Page ();
            }

        }

        [BindProperty]
        public Form form { get; set; }
        public async Task<IActionResult> OnPostAsync () {

            if (!ModelState.IsValid) {
                Console.WriteLine ("Entro1" + HttpContext.Session.GetString (SessionKeyName));

                return Page ();
            } else {
                Console.WriteLine ("Entro2");
                return RedirectToPage ("./agradecimiento");
            }
            //  return RedirectToPage ("./Index");
        }
    }

}