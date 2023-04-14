using Interfaces;

PersonManager personManager = new PersonManager();
personManager.Add(new Customer { Id = 1, FirstName = "Berkay", LastName = "Kiziltug" });


Student student = new Student();
student.FirstName = "Nilay";
student.LastName = "Kiziltug";
personManager.Add(new Customer {FirstName = "Kemir" });
Console.ReadLine();
