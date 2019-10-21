using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using netcore.model;
using Microsoft.AspNetCore.Http;
namespace netcore.Pages.home {
    public class Home : PageModel {
        public void onGet () {
            var name = HttpContext.Session.GetString(SessionKeyName);
        }
        public IActionResult OnGet () {
            return Page ();
        }
        public const string SessionKeyName = "_Name";
        [BindProperty]
        public Usuario usuario { get; set; }
        public async Task<IActionResult> OnPostAsync () {
            if (!ModelState.IsValid) {
                Console.WriteLine ("Entro1");
                return Page ();
            } else {
                Console.WriteLine ("Entro2");
                return RedirectToPage ("./agradecimiento");
            }
            
        }
    }

}