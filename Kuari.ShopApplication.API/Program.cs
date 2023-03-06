using FluentValidation.AspNetCore;
using Kuari.ShopApplication.Core.DTOs;
using Kuari.ShopApplication.Core.Repositories;
using Kuari.ShopApplication.Repository.Contexts;
using Kuari.ShopApplication.Repository.Repositories;
using Kuari.ShopApplication.Service.Validations.ProductDtosValidations;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddFluentValidation(x =>
{
    x.RegisterValidatorsFromAssemblyContaining<ProductCreateDtoValidator>();
});

builder.Services.AddDbContext<ShopApplicationContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), options =>
    {
        options.MigrationsAssembly(Assembly.GetAssembly(typeof(ShopApplicationContext)).GetName().Name);
    });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
