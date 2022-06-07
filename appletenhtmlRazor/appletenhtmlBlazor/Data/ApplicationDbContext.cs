using appletenhtmlRazor.Model;
using Microsoft.EntityFrameworkCore;

namespace appletenhtmlRazor.Data
{
    //23 ApplicationDbContext
    //Para poder usar esto se instalo
    /*
     entityframework.core
        y
    entityframeworkCore.sqlServer
     
     */
    public class ApplicationDbContext : DbContext
    {
        //ctor + tab = atajo
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Article> Article { get; set; }

    }
}
