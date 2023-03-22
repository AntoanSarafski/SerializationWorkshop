using System;

namespace SerializationWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = Serializator.Load<Product>();

            if (product == null)
            {
                product = new Product()
                {
                    Id = 1,
                    Price = 100,
                    Model = "New"
                };
            }
            

            Serializator.Save(product);
            
        }

        
    }
}
