using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TestRamsay.Bussiness.Implementations;
using TestRamsay.Bussiness.Interfaces;
using TestRamsay.Data;
using TestRamsay.Data.Implementations;
using TestRamsay.Data.Interfaces;


var builder = WebApplication.CreateBuilder(args);
var corsPolicy = "CorsPolicy";

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddTransient<IGenderRepository, GenderRepository>();
builder.Services.AddTransient<IDegreeRepository, DegreeRepository>();
builder.Services.AddTransient<IStudentRepository, StudentRepository>();
builder.Services.AddTransient<IGenderService, GenderService>();
builder.Services.AddTransient<IDegreeService, DegreeService>();
builder.Services.AddTransient<IStudentServive, StudentServive>();
builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles);

builder.Services.AddDbContext<TestRamsayDBContext>(options =>
    options.UseSqlite("name=DefaultConnection"));
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builderx => builderx.WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .AllowAnyMethod()
        );
});

var app = builder.Build();
app.UsePathBase(new PathString("/api/service"));
app.UseRouting();
app.UseCors(corsPolicy);


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
