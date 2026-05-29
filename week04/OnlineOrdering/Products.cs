using System;
using System.Security.Principal;

public class Product
{
    private string _name;
    private string _productId;
    private int _price;
    private int _quantity;

    public Product(string name, string productId, double price ,int quantity)
    {
        name = _name;
        productId = _productId;
        price = _price;
        quantity = _quantity;
    }

    public double GetTotalCost()
    {
        return _price *_quantity;
    }

    public string GetPackingInfo()
    {
        return $"{_name} ({_productId})";
    }
}