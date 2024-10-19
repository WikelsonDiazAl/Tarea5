using Microsoft.EntityFrameworkCore;

public class JuegosContext : DbContext
{
    public DbSet<Videojuegos> Videojuegos { get; set; }
    public DbSet<Plataforma> Plataformas { get; set; }
    public DbSet<Personajes_Videojuegos> Personajes { get; set; }

    public JuegosContext(DbContextOptions<JuegosContext> options) : base(options)
    {
    }

}