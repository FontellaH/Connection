
using Microsoft.EntityFrameworkCore;  //#6 add in the framework
using Connection.Models;   //#7  You will need access to your models for your context file


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");  // #8 Create a variable to hold your connection string from appsetting.json

// Add services to the container.
builder.Services.AddControllersWithViews();// #1 AddHttpContextAccessor gives our views direct access to session
builder.Services.AddHttpContextAccessor();  // #2 They fit nicely right after AddControllerWithViews() // Add these two lines before calling the builder.Build() method
builder.Services.AddSession(); 
builder.Services.AddDbContext<MyContext>(options =>  //#9 Accessing mycontext.cs file
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
}); 


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseSession();   //#3 It fits nicely with other Use statements like app.UseStaticFiles(); // add this line before calling the app.MapControllerRoute() method


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


// #4 Go set up the model for Pets next

//#10 make controller to start makin the table in db... migration and Controller on platform
// #10.1 add dotnet ef migrations add FirstMigration in th terminal
// #10.2 this creates a migration folder