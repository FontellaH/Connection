// #5  Get the info below from Setup and Model from platform and copy it below

#pragma warning disable CS8618
// We can disable our warnings safely because we know the framework will assign non-null values 
// when it constructs this class for us.

using Microsoft.EntityFrameworkCore;
 namespace Connection.Models;  // ********* #1 its not yourprojectname... change to Pet or your model class name **************

// the MyContext class represents a session with our MySQL database, allowing us to query for or save data
// DbContext is a class that comes from EntityFramework, we want to inherit its features
public class MyContext : DbContext 
{   
    // This line will always be here. It is what constructs our context upon initialization  
    public MyContext(DbContextOptions options) : base(options) { }    
    // We need to create a new DbSet<Model> for every model in our project that is making a table
    // The name of our table in our database will be based on the name we provide here
    // This is where we provide a plural version of our model to fit table naming standards    
    public DbSet<Pet> Pets { get; set; } //********* #2 Change from Monster to <Pet> model file... i will name my table for sql Pets

    // public DbSet<Pet> Pets { get; set; } if i have more than one table add here
}

// #3 Go to the appsettings.json next to connect to mysql add this below "AllowedHOst
//  #3.1  "ConnectionStrings":    
//     {        
//         "DefaultConnection": "Server=localhost;port=3306;userid=root;password=root;database=****monsterdb*****;"    
//     }  ***** change monterdb to whatever my db is called ******

//#6 Update the program.cs when i do step 3
