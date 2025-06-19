using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContextFactory<OMAContext>(options =>
{

    options.UseInMemoryDatabase("In Memory");
}


);


var app = builder.Build();
app.Run();