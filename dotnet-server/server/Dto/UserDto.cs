namespace server.Dto
{
    public class UserDto
    {
        public int id { get; set; }
        public string name { get; set; } = "";
        public string account { get; set; } = "";
        public string password { get; set; } = "";
        public string role { get; set; } = "member"; // "member" | "admin"
    }

    public class LoginDto
    {
        public string account { get; set; } = "";
        public string password { get; set; } = "";
    }
}
