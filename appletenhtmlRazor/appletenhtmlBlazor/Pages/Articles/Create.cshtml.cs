
using appletenhtmlRazor.Data;
using appletenhtmlRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace appletenhtmlRazor.Pages.Articles
{
    //util para usar el mismo modelo en el OnPost
    [BindProperties]
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _db;


        public Article Article { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()//Article category
        {
            //34. Custom Validation  (verificando que Name y DisplayOrder no sean iguales
            if (Article.Price <= 0)
            {
                ModelState.AddModelError("Article.Price", "El valor debe ser mayor a 0.");
            }

            //33. Validando los requeridos del modelo
            if (ModelState.IsValid)
            {
                await _db.Article.AddAsync(Article);
                await _db.SaveChangesAsync();
                //41. TempData
                TempData["success"] = "Article creado con exito!";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
