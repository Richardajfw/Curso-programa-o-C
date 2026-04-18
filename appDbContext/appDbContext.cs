using Microsoft.EntityFrameworkCore;

namespace API.appDbContext
{
    public class appDbContext: DbContext
    {
        public appDbContext(DbContextOptions<appDbContext> options)
            : base(options)
        {

        } 

        public DbSet<Aluno> Alunos { get; set; }
    }
}
