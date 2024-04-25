using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NoteTakingApp.Config.AppSettings;
using NoteTakingApp.DAL.Database.Entities;

namespace NoteTakingApp.DAL.Database.Context;

public class NotesContext : DbContext
{
    public NotesContext(DbContextOptions<NotesContext> options) : base(options) { }

    public virtual DbSet<Note> Notes { get; set; }
}

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<NotesContext> 
{ 
    public NotesContext CreateDbContext(string[] args) 
    { 
        IConfigurationRoot configuration = new ConfigurationBuilder().Build(); 
        var builder = new DbContextOptionsBuilder<NotesContext>(); 
        var connectionString = configuration.GetConnectionString(ConnectionStrings.NoteTakingDatabase); 
        builder.UseNpgsql(connectionString); 
        return new NotesContext(builder.Options); 
    } 
}