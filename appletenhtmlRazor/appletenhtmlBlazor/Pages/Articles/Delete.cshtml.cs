using appletenhtmlRazor.Data;
using appletenhtmlRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace appletenhtmlRazor.Pages.Articles
{
    [BindProperties]
    public class DeleteModel : PageModel
    {

        private readonly ApplicationDbContext _db;


        public Article Article { get; set; }

        public DeleteModel(ApplicationDbContext db)
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
            //40.Delete Article
            var categoryFromDb = _db.Article.Find(Article.Id);
            if (categoryFromDb != null)
            {
                _db.Article.Remove(categoryFromDb);
                await _db.SaveChangesAsync();
                //41. Temp Data
                TempData["success"] = "Article borrado!";
                return RedirectToPage("Index");
            }



            return Page();
        }
    }
}
