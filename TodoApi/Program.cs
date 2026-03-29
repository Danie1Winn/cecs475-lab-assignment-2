using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

// adds services to container
builder.Services.AddControllers();

// register the database context suing "TodoList"
// stores data in RAM while app runs
builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));

var app = builder.Build();

// HTTP request pipeline config
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// enable default file mapping
app.UseDefaultFiles();
// allows app to serve static files from wwwroot
app.UseStaticFiles();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();