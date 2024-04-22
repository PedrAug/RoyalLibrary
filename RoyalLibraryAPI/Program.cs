using RoyalLibraryAPI;
using RoyalLibraryAPI.Models;
using RoyalLibraryAPI.Repository;
using RoyalLibraryAPI.Service;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddTransient<IBookService, BookService>();
        builder.Services.AddTransient<IBookRepository, BookRepository>();
        builder.Services.AddTransient<DataContext>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}