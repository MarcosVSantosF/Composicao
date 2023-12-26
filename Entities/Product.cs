namespace Ex_Proposto;

public class Product
{
    public string Name {get; set;}
    public double Price {get; set;}

    public Product(){

    }
    public Product(string Pname, double price)
    {
        Name = Pname;
        Price = price;
    }

}
