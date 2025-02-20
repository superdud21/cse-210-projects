class Product
{
    private string _name;
    private string _productID;
    private double _productPrice;
    private int _productQuantity;

    public Product(string name, string productID, double productPrice, int productQuantity)
    {
        _name = name;
        _productID = productID;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public double GetTotalCost()
    {
        return _productPrice * _productQuantity;
    }

    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_productID})";
    }
}