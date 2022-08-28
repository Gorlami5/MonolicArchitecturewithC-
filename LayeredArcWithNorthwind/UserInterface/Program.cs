
using BusinessLayer;
using DataAcessLayer;


IProductManager productmanager = new ProductManager(new ProductDal());
IEmployeeManager employeemanager = new EmployeeManager(new EmployeeDal());
ICustomerManager customermanager = new CustomerManager(new CustomerDal());

foreach (var product in productmanager.GetAll())
{
    Console.WriteLine(product.ProductName);
}

// Another Process (Product)

//Console.WriteLine(productmanager.GetById(3).ProductName) ;
//ProductDelete();
//ProductAdd();
//ProductUpdate();
//********************************************************************************************************//
Console.WriteLine("************************Employee List****************************");



foreach (var employee in employeemanager.GetAll())
{
    Console.WriteLine(employee.Name);
}

// Another Process (Employee)

//EmployeeAdd();
//EmployeeDelete();
//EmployeeUpdate();


Console.WriteLine("***************************Customer.CompanyName List***************************");
foreach (var customer in customermanager.GetAllAsync().Result)
{
    Console.WriteLine(customer.CompanyName);
}

//Another Process(CustomerAsync)
//CustomerAddAsync();








void ProductAdd() { 

    try
{
    productmanager.Add(new Entites.Product() { ProductName = "Monster", QuantityPerUnit = "Abra A5", UnitPrice = 10000, UnitsInStock = 5, });
}
    catch (SameProductException exception)
{
        Console.WriteLine(exception.Message);
}
    
}

void ProductDelete()
{
    productmanager.Delete(new Entites.Product { ProductID = 78, ProductName = "Monster", QuantityPerUnit = "Abra A5", UnitPrice = 10000, UnitsInStock = 5});
}

void ProductUpdate()
{
    productmanager.Update(new Entites.Product { ProductID = 79, ProductName = "Monster3", QuantityPerUnit = "Abra A7", UnitPrice = 14000, UnitsInStock = 0});
}
void EmployeeAdd()
{
    try
    {
        employeemanager.Add(new Entites.Employee() { Name = "Muhammet", Surname = "Yonkuç" });
    }
    catch (SameProductException exception)
    {
        Console.WriteLine(exception.Message);
    }
    
}

void EmployeeDelete()
{
    employeemanager.Delete(new Entites.Employee() { Id = 10, Name = "Muhammet", Surname = "Yonkuç" });
}

void EmployeeUpdate()
{
    employeemanager.Update(new Entites.Employee() { Id = 10, Name = "Ömer Faruk", Surname = "Has" });
}

void CustomerAddAsync()
{
    customermanager.AddAsync(new Entites.Customer { CustomerID = "ZOLZA", CompanyName = "Amazon", ContactName = "Sam Anderson", Country = "USA" });
}
