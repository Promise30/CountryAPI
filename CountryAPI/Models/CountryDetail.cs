namespace CountryAPI.Models
{
    public class CountryDetail
    {
        public Name? name { get; set; }
        public string? cca2 { get; set; }
        public string? cca3 { get; set; }
        public Currencies? currencies { get; set; }
        public string[]? capital { get; set; }
        public string? region { get; set; }
        public string? subregion { get; set; }
        public Languages? languages { get; set; }
        public float[]? latlng { get; set; }
        public int? population { get; set; }
        public Capitalinfo? capitalInfo { get; set; }

    }
    public class Name
    {
        public string? common { get; set; }
        public string? official { get; set; }

    }
    public class Currencies
    {
        public NGN? NGN { get; set; }
    }

    public class NGN
    {
        public string? name { get; set; }
        public string? symbol { get; set; }
    }
    public class Languages
    {
        public string? eng { get; set; }
    }
    public class Capitalinfo
    {
        public float[]? latlng { get; set; }
    }
}
