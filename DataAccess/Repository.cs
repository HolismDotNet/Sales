namespace Sales;

public class Repository
{
    public static Write<Sales.SoldPackage> SoldPackage
    {
        get
        {
            return new Write<Sales.SoldPackage>(new SalesContext());
        }
    }
}
