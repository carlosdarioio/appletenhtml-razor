using appletenhtmlRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace appletenhtmlRazor.Pages.EjSuma
{
    //util para usar el mismo modelo en el OnPost
    [BindProperties]
    public class IndexModel : PageModel
    {

        public Suma Suma { get; set; }
        

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()//Category category
        {
            //34. Custom Validation  (verificando que Name y DisplayOrder no sean iguales
            if (Suma.Numero1 == Suma.Numero2)
            {
                ModelState.AddModelError("Suma.Numero1", "Poner numeros diferentes.");
                TempData["error"] = "Poner numeros diferentes";
            }

            //33. Validando los requeridos del modelo
            if (ModelState.IsValid)
            {
                //41. TempData
                TempData["success"] = "Suma realizada!";
                //Suma.Resultado = Suma.Numero1 + Suma.Numero2;
                TempData["Resultado"] = Suma.Numero1+Suma.Numero2;
                //return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
