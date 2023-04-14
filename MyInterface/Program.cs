using MyInterface;

IPersonManager customerManager = new CustomerManager();
IPersonManager employeeManager = new EmployeeManager();
IPerson customer1 = new Customer();
IPerson employee1 = new Employee();
//customerManager.Add();
//employeeManager.Log();

PersonManager personManager = new PersonManager();
personManager.Add(customerManager);
personManager.Add(employeeManager);
personManager.Update(customerManager);
EmployeeManager employeeManager2 = new EmployeeManager();
employeeManager2.Change();