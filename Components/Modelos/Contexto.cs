using Microsoft.EntityFrameworkCore;

public class Contexto: DbContext{

    public DbSet<Detenciones> detenciones{get; set;}

    public Contexto(DbContextOptions<Contexto> options): base(options){}
}