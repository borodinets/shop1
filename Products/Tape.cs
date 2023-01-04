namespace Shop.Products
{
    class Tape : Product
    {
        public string Size {get ; private set;}
        public  Tape (string name, int price, string manufacturer,  string size)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Size = size;
        }
    }
}
    