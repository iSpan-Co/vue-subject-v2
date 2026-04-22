using server.Dto;

namespace server.Data
{
    public class UserData
    {
        public static List<UserDto> datas = new()
        {
            new UserDto { id = 1, name = "小橘", account = "orange", password = "1234", role = "member" },
            new UserDto { id = 2, name = "小花", account = "flower", password = "1234", role = "member" },
            new UserDto { id = 3, name = "管理員", account = "admin", password = "admin1234", role = "admin" },
        };
    }
}
