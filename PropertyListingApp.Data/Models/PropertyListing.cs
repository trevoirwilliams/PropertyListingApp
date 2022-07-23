namespace PropertyListingApp.Data.Models
{
    public class PropertyListing : BaseEntity<int>
    {
        public string Address { get; set; }
        public decimal Cost { get; set; }
        public string Description{ get; set; }

        public City City { get; set; }
        public int CityId { get; set; }

        public PropertyType PropertyType { get; set; }
        public int PropertyTypeId { get; set; }

        public ContractType ContractType { get; set; }
        public int ContractTypeId { get; set; }

        public Currency Currency { get; set; }
        public int CurrencyId { get; set; }

        public ApiUser ApiUser { get; set; }
        public string ApiUserId { get; set; }

        public List<PropertyFeature> PropertyFeatures { get; set; }
    }
}
