namespace Shop.Products
{
    class disiac : Product
    {
        public string Composition {get ; private set;}
        public  disiac(string name, string manufacturer, int price, string composition)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Composition = composition;
        }
    }
}
    