namespace PropertyListingApp.Data.Models
{
    public class Currency : BaseEntity<int>
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
