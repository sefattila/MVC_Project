using Microsoft.EntityFrameworkCore;
using MVC_Project.AutoMapper;
using MVC_Project.Context;
using MVC_Project.Repositories.Abstracts;
using MVC_Project.Repositories.Concretes;
using MVC_Project.Services.LessonService;
using MVC_Project.Services.SchoolService;
using MVC_Project.Services.StudentService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(typeof(Mapping));

var conn = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(conn);
    options.UseLazyLoadingProxies();
});

builder.Services.AddTransient<ILessonRepo, LessonRepo>();
builder.Services.AddTransient<ISchoolRepo, SchoolRepo>();
builder.Services.AddTransient<IStudentRepo, StudentRepo>();

builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddTransient<ISchoolService, SchoolService>();
builder.Services.AddTransient<ILessonService, LessonService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
