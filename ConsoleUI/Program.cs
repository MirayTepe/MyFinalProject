
using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
//using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //  ProductMethod2();


           // ProductTest();
            //CategoryTest();
        }

        //private static void ProductMethod2()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());

        //    foreach (var product in productManager.GetByUnitPrice(50, 100))
        //    {
        //        Console.WriteLine(product.ProductName);

        //    }
        //}

        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        //    foreach (var category in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}

        //private static void ProductTest()
        //{
        //  ProductManager productManager = new ProductManager(new EfProductDal());

        //    var result = productManager.GetProductDetails();
        //    if (result.Success==true)
        //    {
        //       foreach (var product in result.Data)
        //       {
        //        Console.WriteLine(product.ProductName+"/"+product.CategoryName);
 
        //       }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }

            
          
        //}
    }

}
