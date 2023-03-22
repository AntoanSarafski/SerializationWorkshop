using System;

namespace SerializationWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                Id = 1,
                Price = 100,
                Model = "New"
            };

            Serializator.Save(product);
            
        }

        
    }
}
