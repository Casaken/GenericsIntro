using Interfaces2;

PersonManager personManager= new PersonManager();

IPersonManager customerManager = new CustomerManager();
personManager.Remove(customerManager);

personManager.Add(new EmployeeManager());

personManager.Update(customerManager);



