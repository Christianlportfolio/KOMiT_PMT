using KOMiT.App.Service;
using KOMiT.App.Service.Implementations;
using KOMiT.DataAccess.Persistence;
using KOMiT.DataAccess.Repositories;
using KOMiT.DataAccess.Repositories.Implementations;
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddKOMiTApp();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<ICurrentPhaseService, CurrentPhaseService>();
builder.Services.AddScoped<ICurrentPhaseRepository, CurrentPhaseRepository>();
builder.Services.AddScoped<IStandardPhaseService, StandardPhaseService>();
builder.Services.AddScoped<IStandardPhaseRepository, StandardPhaseRepository>();
builder.Services.AddScoped<ICurrentSubGoalService, CurrentSubGoalService>();
builder.Services.AddScoped<ICurrentSubGoalRepository, CurrentSubGoalRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IProjectMemberService, ProjectMemberService>();
builder.Services.AddScoped<IProjectMemberRepository, ProjectMemberRepository>();
builder.Services.AddScoped<ICompetenceService, CompetenceService>();
builder.Services.AddScoped<ICompetenceRepository, CompetenceRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blazor API V1");
    });
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
