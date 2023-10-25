// See https://aka.ms/new-console-template for more information
using Classes;

Console.WriteLine("Hello, World!");
CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.City = "Antalya";
customer.Id = 1;
customer.FirsName = "Kamil";
customer.LastName = "Deniz";

Customer customer2 = new Customer
{
    Id = 2,FirsName="Engin",LastName="Demiroğ",City="Ankara"
};