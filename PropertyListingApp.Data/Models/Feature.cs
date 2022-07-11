namespace PropertyListingApp.Data.Models
{
    public class Feature : BaseEntity<int>
    {
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
