namespace RESTAPIDEMO.Models
{
    public class Trainee
    {
        public int TraineeId { get; set; }
        public string Name { get; set; }
        public string Technology { get; set; }
        public int Score { get; set; }
    }
}

//Different ways to Configure the Model Classes
// 1. Default Conventions: By default, EF Core will use conventions to determine how to map the model
// classes to the database. For example, it will assume that a property named "Id" is the primary key
// and that a property named "Name" is a string column in the database.

// 2.Annotations: You can use data annotations to configure the model classes.
// For example, you can use the [Key] attribute to specify the primary key, and the
// [Column] attribute to specify the column name in the database.

//3. Fluent API: You can use the Fluent API to configure the model
//classes in the OnModelCreating method of the DbContext class.

// If any of the validation rules are not able to be applied either 
// using Data Annotations or Fluent API,
// then the model will not be valid and an exception will be thrown when you try to save changes to the database.
// in this scenario we can make use of ModelState.IsValid property to check if the model is valid before trying to save changes to the database.

