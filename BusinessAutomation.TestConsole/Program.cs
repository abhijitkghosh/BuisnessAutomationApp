 //CRUD
//Create Product
using BuisnessAutomation.Database;
using BusinessAutomation.Repositories;
using BusinessAutomations.Models.EntityModels;
List<Product> Products =new List<Product>() 
{ 
new Product()
{
    Name = "Product1",
    Description="Product Description",
    SalesPrice=016516,
    Brand = "Brand A"
},
new Product()
{
    Name = "Product2",
    Description = "Product 2 Description",
    SalesPrice = 15661,
    Brand="Brand B"
},
new Product()
{
    Name = "Product3",
    Description = "Product 3 Description",
    SalesPrice = 25000,
    Brand = "Brand A"
},
new Product()
{
    Name = "Product4",
    Description = "Product 4 Description",
    SalesPrice = 65141,
    Brand = "Brand B"
}
};

//Repository PROCESS 
ProductRepository productsRepository = new ProductRepository();
//BusinessAutomationDbContext db = new BusinessAutomationDbContext();
//db.Products.AddRange(Products);
bool IsSucsess=productsRepository.AddList(Products);
if (IsSucsess)
{
    Console.WriteLine("ADDLIST Successfully");
}
//update
var existingProduct = productsRepository.GetById(1);
//db.Products.FirstOrDefault(p=>p.Id==2) ;
existingProduct.Description = "Samsung Monitor [Updatred]";
existingProduct.SalesPrice = 10000;
bool isSuccess= productsRepository.Update(existingProduct);

//save Change likhar por uporer command gulo ak sathe execute hoi
//int successCount=db.SaveChanges();
if(isSuccess)
{
    Console.WriteLine("Saved Successfully");
}