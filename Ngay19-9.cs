using System;
using System.Collections.Generic;

// Lop cha: San pham (Product)
class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }

    public Product(string name, decimal price, string description, int quantity)
    {
        Name = name;
        Price = price;
        Description = description;
        Quantity = quantity;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Ten san pham: {Name}, Gia: {Price}, Mo ta: {Description}, So luong: {Quantity}");
    }
}

// Lop con: Dien tu (Electronic) ke thua tu Product
class Electronic : Product
{
    public int Warranty { get; set; } // So thang bao hanh

    public Electronic(string name, decimal price, string description, int quantity, int warranty)
        : base(name, price, description, quantity)
    {
        Warranty = warranty;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Bao hanh: {Warranty} thang");
    }
}

// Lop con: Quan ao (Clothing) ke thua tu Product
class Clothing : Product
{
    public string Size { get; set; }
    public string Color { get; set; }

    public Clothing(string name, decimal price, string description, int quantity, string size, string color)
        : base(name, price, description, quantity)
    {
        Size = size;
        Color = color;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Kich thuoc: {Size}, Mau sac: {Color}");
    }
}

// Lop con: Thuc pham (Food) ke thua tu Product
class Food : Product
{
    public DateTime ExpirationDate { get; set; }

    public Food(string name, decimal price, string description, int quantity, DateTime expirationDate)
        : base(name, price, description, quantity)
    {
        ExpirationDate = expirationDate;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Ngay het han: {ExpirationDate.ToShortDateString()}");
    }
}

// Lop gio hang: ShoppingCart
class ShoppingCart
{
    public List<Product> Products { get; private set; }

    public ShoppingCart()
    {
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
        Console.WriteLine($"Da them {product.Name} vao gio hang.");
    }

    public void RemoveProduct(string productName)
    {
        Product productToRemove = Products.Find(p => p.Name == productName);
        if (productToRemove != null)
        {
            Products.Remove(productToRemove);
            Console.WriteLine($"Da xoa {productName} khoi gio hang.");
        }
        else
        {
            Console.WriteLine($"San pham {productName} khong co trong gio hang.");
        }
    }

    public void DisplayCart()
    {
        if (Products.Count == 0)
        {
            Console.WriteLine("Gio hang trong.");
        }
        else
        {
            Console.WriteLine("Cac san pham trong gio hang:");
            foreach (Product product in Products)
            {
                product.DisplayInfo();
                Console.WriteLine();
            }
        }
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.Price;
        }
        Console.WriteLine($"Tong gia tri don hang: {total} VND");
        return total;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tao san pham mau
        Electronic laptop = new Electronic("Laptop", 15000000, "Laptop gaming", 10, 24);
        Clothing tshirt = new Clothing("T-Shirt", 250000, "Ao thun chat lieu cotton", 50, "L", "Trang");
        Food apple = new Food("Apple", 20000, "Tao nhap khau", 100, new DateTime(2024, 12, 31));

        // Tao gio hang
        ShoppingCart cart = new ShoppingCart();

        // Them san pham vao gio hang
        cart.AddProduct(laptop);
        cart.AddProduct(tshirt);
        cart.AddProduct(apple);

        // Hien thi cac san pham trong gio hang
        cart.DisplayCart();

        // Tinh tong gia tri don hang
        cart.CalculateTotal();

        // Xoa san pham khoi gio hang
        cart.RemoveProduct("T-Shirt");

        // Hien thi lai gio hang va tinh tong gia tri don hang
        cart.DisplayCart();
        cart.CalculateTotal();
    }
}
