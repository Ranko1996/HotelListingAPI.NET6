namespace HotelListingAPI.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public double Rating { get; set; }

        public virtual IList<Country> Countries { get; set; }   
    }
}
