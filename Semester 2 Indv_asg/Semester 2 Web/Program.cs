using Domain.Users;
using Domain.Animals;
using Domain.Shelters;
using Logic.Services.Animals;
using Logic.Services.Adoption;
using Logic.Services.UserService;
using Logic.Services.ShelterService;
using Logic.Services.PaginationAndFilter;
using Logic.Services.Animals.CatService;
using Logic.Services.Animals.DogService;
using Logic.Services.Animals.BirdService;
using Logic.Services.Animals.HamsterService;
using Repository.Database.Users;
using Repository.Database.Animals;
using Repository.Database.Shelters;
using Repository.Database.Adoption;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options => {
    options.LoginPath = new PathString("/Login");
    options.AccessDeniedPath = new PathString("/Error");
}
);

builder.Services.AddRazorPages();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(15);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// --Dependency Injection--

// User
builder.Services.AddScoped<UserManager>();
builder.Services.AddScoped<IUserDB, UserDB>();
// Shelter
builder.Services.AddScoped<ShelterManager>();
builder.Services.AddScoped<IShelterDB, ShelterDB>();
// Animals
builder.Services.AddScoped<AnimalManager>();
builder.Services.AddScoped<CatManager>();
builder.Services.AddScoped<DogManager>();
builder.Services.AddScoped<BirdManager>();
builder.Services.AddScoped<HamsterManager>();
builder.Services.AddScoped<IAnimalDB, AnimalDB>();
builder.Services.AddScoped<ICatDB, CatDB>();
builder.Services.AddScoped<IDogDB, DogDB>();
builder.Services.AddScoped<IBirdDB, BirdDB>();
builder.Services.AddScoped<IHamsterDB, HamsterDB>();
//Adoption
builder.Services.AddScoped<PendingAdoptionManager>();
builder.Services.AddScoped<IPendingAdoptionDB, PendingAdoptionDB>();
// Filtering
builder.Services.AddScoped<Filter<Animal>>();
builder.Services.AddScoped<Filter<Cat>>();
builder.Services.AddScoped<Filter<Dog>>();
builder.Services.AddScoped<Filter<Bird>>();
builder.Services.AddScoped<Filter<Hamster>>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
