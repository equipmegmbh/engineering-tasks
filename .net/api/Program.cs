var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//  Discussion Topic: Dependency Injections & Interfaces
//  Why dependency injection?
//  Why interfaces?
builder.Services.AddScoped<IProductsLogic, ProductsLogic>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//  Discussion Topic: Authorization in SaaS web apis
//  Authorization vs. Authentication
//  Authorization scope
//  Resource based authorization 
app.UseAuthorization();

app.MapControllers();

app.Run();
