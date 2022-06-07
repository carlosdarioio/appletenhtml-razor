using appletenhtmlRazor.Data;
using appletenhtmlRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace appletenhtmlRazor.Pages.Articles
{
    [BindProperties]
    public class EditModel : PageModel
    {

        private readonly ApplicationDbContext _db;


        public Article Article { get; set; }

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            Article = _db.Article.Find(id);
            //otros comandos
            //Article = _db.Article.First(u=>u.Id==id);
            //Article = _db.Article.SingleOrDefault(u=>u.Id==id);
            //Article = _db.Article.Where(u=>u.Id==id).FirstOrDefault();
        }

        public async Task<IActionResult> OnPost()
        {
            if (Article.Price <=0)
            {
                ModelState.AddModelError("Article.Price", "El Precio debe de mayor o igual a 0");
            }
            if (ModelState.IsValid)
            {
                _db.Article.Update(Article);
                await _db.SaveChangesAsync();
                //41. Temp Data
                TempData["success"] = "Articulo actualizado!";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
