namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


        public override bool Equals(object obj)
        {
            if (obj is Product productToFind)
            {
                return Name == productToFind.Name && Price == productToFind.Price;
            }

            return false;
        }

        public string Name { get; set; }

        public double Price { get; set; }
    }
}
