using Microsoft.EntityFrameworkCore;
using StudentAdminPotal.Data;
using StudentAdminPotal.Profiles;
using StudentAdminPotal.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<StudentDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("StudentConnectionStrings")));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IStudent, StudentRepository>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
<<<<<<< HEAD

app.UseHttpsRedirection();
app.UseCors(policy=>policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());



=======
<<<<<<< HEAD
app.UseHttpsRedirection();
app.UseCors(policy=>policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
=======

>>>>>>> e934563d2c3c35585eb74d084d55a82c7c8d6c6f
>>>>>>> 0287b490315fa22b224992bdc4d7af4056f0f83f
app.UseAuthorization();

app.MapControllers();

app.Run();
