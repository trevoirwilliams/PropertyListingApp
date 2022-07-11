namespace PropertyListingApp.Data.Models
{
    public class Picture : BaseEntity<int>
    {
        public string Path { get; set; }

        public PropertyListing PropertyListing { get; set; }
        public int PropertyListingId { get; set; }
    }

}
