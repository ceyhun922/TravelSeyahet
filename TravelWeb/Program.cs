using DAL.Abstract;
using DAL.Concrete;
using DAL.Entityframework;
using Entities.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using Services.Concrete;
using Services.ValidationRule;
using ServicesLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(opt =>
{
    opt.ModelMetadataDetailsProviders.Clear();

    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();

    opt.Filters.Add(new AuthorizeFilter(policy));
});



builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();

builder.Services.AddHttpContextAccessor();

builder.Services.AddValidatorsFromAssemblyContaining<RegisterValidation>();
builder.Services.AddValidatorsFromAssemblyContaining<LoginValidation>();
builder.Services.AddValidatorsFromAssemblyContaining<ChangePassword>();

builder.Services.AddScoped<IDestinationDAL, EFDestinationRepository>();
builder.Services.AddScoped<IDestinationService, DestinationManager>();
builder.Services.AddScoped<IGuideDAL, EFGuideRepository>();
builder.Services.AddScoped<IGuideService, GuideManager>();
builder.Services.AddScoped<ITourDAL, EFTourRepository>();
builder.Services.AddScoped<ITourService, TourManager>();
builder.Services.AddScoped<IRezervationDAL, EFRezervationRepository>();
builder.Services.AddScoped<IRezervationService, RezervationManager>();
builder.Services.AddScoped<IRotasionDAL, EFRotasionRepository>();
builder.Services.AddScoped<IRotasionService, RotasionManager>();

builder.Services.AddScoped<IWriterDAL, EFWriterRepository>();
builder.Services.AddScoped<IWriterService, WriterManager>();

builder.Services.AddScoped<IRotasionDAL, EFRotasionRepository>();
builder.Services.AddScoped<IRotasionService, RotasionManager>();


builder.Services.AddScoped<ICommentDAL, EFCommentRepository>();
builder.Services.AddScoped<ICommentService, CommentManager>();


builder.Services.AddDbContext<Context>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("AzTourConnect"), m => m.MigrationsAssembly("TravelWeb"));
});

builder.Services.AddIdentity<Writer, Role>(opt =>
{
    opt.Password.RequireDigit = false;
    opt.Password.RequiredLength = 1;
    opt.Password.RequiredUniqueChars = 0;
    opt.Password.RequireLowercase = false;
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireUppercase = false;
}).AddEntityFrameworkStores<Context>().AddDefaultTokenProviders();


builder.Services.ConfigureApplicationCookie(opt =>
{
    opt.Cookie.Name = "MyCookie";
    opt.LoginPath = "/Login/Index";
    opt.LogoutPath = "/Login/Logout";
    opt.AccessDeniedPath = "/Login/Index";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();


app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoint =>
{
   
    endpoint.MapAreaControllerRoute(
        name: "admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
        
    );

     endpoint.MapControllerRoute(
     name: "default",
     pattern: "{controller=Home}/{action=Index}/{id?}");


});

app.Run();
