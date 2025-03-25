using ApplicationCore.Commons.Repository;
using ApplicationCore.Models;
using ApplicationCore.Models.QuizAggregate;
using BackendLab01;
using Infrastructure.Memory.Generators;
using Infrastructure.Memory.Repositories;
using WebAPI;


var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddControllers();
// builder.Services.AddRazorPages();
// builder.Services.AddSingleton(typeof(IGenericRepository<,>), typeof(MemoryGenericRepository<,>));
// builder.Services.AddSingleton<IQuizUserService, QuizUserService>();
// builder.Services.AddSingleton<IQuizAdminService, QuizAdminService>();
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IGenericGenerator<int>, IntGenerator>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddSingleton<IGenericRepository<Quiz, int>, MemoryGenericRepository<Quiz, int>>();
builder.Services.AddSingleton<IGenericRepository<QuizItem, int>, MemoryGenericRepository<QuizItem, int>>();
builder.Services.AddSingleton<IGenericRepository<QuizItemUserAnswer, string>, MemoryGenericRepository<QuizItemUserAnswer, string>>();
builder.Services.AddSingleton<IQuizUserService, QuizUserService>();
builder.Services.AddSingleton<IQuizAdminService, QuizAdminService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapControllers();
app.Seed();

app.Run();
