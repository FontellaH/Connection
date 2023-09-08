// #4 Set up the Model

#pragma warning disable CS8618  //#1

using System.ComponentModel.DataAnnotations;  //connected to line 11 this will bring itself in when iadd the KEY

namespace Connection.Models; //#2

public class Pet //#3
{
    [Key]//This is the primary key... this will also bring the code in for line 3
    public int PetId {get; set;}  //every table will need a special id related to mysql
    public int Id { get; set; }
    public string Name { get; set; }
    public string PetType { get; set; }
    public int Age { get; set; }
    public bool HasFur { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;  // When an object of this class is created, and represents a date and time.
    
    public DateTime UpdatedAt { get; set; } = DateTime.Now; //It's set to the current date and time when an object is created, and it may be updated later to record when the object was last modified.
}

// #5 model is set up.... now make a new file in Models and make a new file called Context.cs file