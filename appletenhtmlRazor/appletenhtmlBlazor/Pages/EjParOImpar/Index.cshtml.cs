using appletenhtmlRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace appletenhtmlRazor.Pages.EjParOImpar
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        
        public int Numero{ get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()//Category category
        {
            if (Numero <= 0)
            {
                ModelState.AddModelError("Numero", "Ingresar numero mayor a 0");
                TempData["error"] = "Numero incorrecto";
            }

            //33. Validando los requeridos del modelo
            if (ModelState.IsValid)
            {
                string resultado = Numero % 2 == 0 ? "Par" : "Impar";
                TempData["success"] = "El numero introducido es " + resultado;
                TempData["Resultado"] = "El numero introducido es " + resultado;

            }
            return Page();
        }
    }
}
