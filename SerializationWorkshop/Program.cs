using System;

namespace SerializationWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Product loadedProduct = Serializator.Load<Product>();

            if (loadedProduct == null)
            {
                loadedProduct = new Product()
                {
                    Id = 1,
                    Price = 100,
                    Model = "New"
                };
            }
            

            Serializator.Save(loadedProduct);
        }
        public class Product
        {


            public int Id { get; set; }

            public decimal Price { get; set; }

            public int Quantity { get; set; }

            public string Model { get; set; }
        }


    }
}
