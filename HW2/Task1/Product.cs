namespace C_Pro_Practice.HW2;

public class Product
{
    public Money Price { get; set; }

    public Product(Money price)
    {
        Price = price;
    }

    public void DecreasePrice(Money value)
    {
        Price.DecreaseBalance(value);
    }
    
}