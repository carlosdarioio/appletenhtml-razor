using appletenhtmlRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace appletenhtmlRazor.Pages.EjPotence
{
    //util para usar el mismo modelo en el OnPost
    [BindProperties]
    public class IndexModel : PageModel
    {

        public Potencia Potencia { get; set; }


        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()//Category category
        {
            //34. Custom Validation  (verificando que Name y DisplayOrder no sean iguales
            if (Potencia.Base == Potencia.Exponente)
            {
                ModelState.AddModelError("Suma.Numero1", "Poner numeros diferentes.");
                TempData["error"] = "Poner numeros diferentes";
            }

            //33. Validando los requeridos del modelo
            if (ModelState.IsValid)
            {                
                TempData["success"] = "Potencia Calculada!";                
                TempData["resultado"] = calPontence();                
            }
            return Page();
        }

        public float calPontence() {
            float potence = 1;
            while (Potencia.Exponente > 0)
            {
                potence = potence * Potencia.Base;
                Potencia.Exponente--;
            }
            return potence;
        }
    }
}

