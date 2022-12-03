
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
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (Product product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);

            }
        }
    }

}
