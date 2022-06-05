using appletenhtmlRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace appletenhtmlRazor.Pages.EjAnyoBisiesto
{
    [BindProperties]
    public class YearBisiest : PageModel
    {

        public int Year { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()//Category category
        {
            if (Year <= 0)
            {
                ModelState.AddModelError("Numero", "Ingresar A�o mayor a 0");
                TempData["error"] = "A�o incorrecto";
            }

            //33. Validando los requeridos del modelo
            if (ModelState.IsValid)
            {
                string result = ((((Year % 100) != 0) && ((Year % 4) == 0)) || ((Year % 400) == 0))  ? "Es Bisiesto" : "No es Bisiesto";
                TempData["success"] = "El a�o introducido " + result;
                TempData["result "] = "El a�o introducido " + result;

            }
            return Page();
        }
    }
}
