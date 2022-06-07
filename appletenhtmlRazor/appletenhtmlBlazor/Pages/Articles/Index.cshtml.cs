
using appletenhtmlRazor.Data;
using appletenhtmlRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace appletenhtmlRazor.Pages.Articles
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IEnumerable<Article> Articles { get; set; }

        //ctor = atajo
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            //select * from category
            Articles = _db.Article;
        }
    }
}
