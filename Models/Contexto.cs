using Microsoft.EntityFrameworkCore;


namespace asp_dotnet_project.Models
{
    public class Contexto: DbContext
    {
        public DbSet<Categoria> Categorias {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            // Aqui ele vai criar esse DB e utilizar essa classe para acessa-lo
            optionsBuilder.UseSqlServer(connectionString:@"Server=(localdb)\mssqllocaldb;Database=asp-dotnet-project;Integrated Security=True");
        }        
    }
}