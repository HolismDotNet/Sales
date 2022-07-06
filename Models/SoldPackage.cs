namespace Sales;

public class SoldPackage : IEntity, IGuid
{
    public SoldPackage()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid Guid { get; set; }

    public dynamic RelatedItems { get; set; }
}
