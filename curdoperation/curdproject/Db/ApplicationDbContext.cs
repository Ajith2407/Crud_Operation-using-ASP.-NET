using curdproject.model;
using Microsoft.EntityFrameworkCore;

namespace curdproject.Db
{
    public class ApplicationDbContext: DbContext // call to using Microsoft.EntityFrameworkCore;
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {
                
        }
        public DbSet<Student> students { get; set; }  // Student model call to  using curdproject.model; creating purpose for db creation
    }
}
