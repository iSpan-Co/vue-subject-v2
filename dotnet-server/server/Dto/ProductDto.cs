namespace server.Dto
{
    public class ProductDto
    {
        public int id { get; set; }
        public string name { get; set; } = "";
        public string category { get; set; } = "";
        public int price { get; set; }
        public int stock { get; set; }
        public string imageUrl { get; set; } = "";
        public string desc { get; set; } = "";
    }

    public class ProductFormDto
    {
        public string name { get; set; } = "";
        public string category { get; set; } = "";
        public int price { get; set; }
        public int stock { get; set; }
        public string imageUrl { get; set; } = "";
        public string desc { get; set; } = "";
    }
}
