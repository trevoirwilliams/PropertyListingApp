namespace PropertyListingApp.Data.Models
{
    public class PropertyFeature : BaseEntity<int>
    {
        public Feature Feature { get; set; }
        public int FeatureId { get; set; }

        public PropertyListing PropertyListing { get; set; }
        public int PropertyListingId { get; set; }
    }

}
