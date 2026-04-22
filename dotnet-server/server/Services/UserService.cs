using Microsoft.IdentityModel.Tokens;
using server.Data;
using server.Dto;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace server.Services
{
    public class UserService
    {
        private readonly List<UserDto> _users = UserData.datas;
        private readonly IConfiguration _config;

        public UserService(IConfiguration config)
        {
            _config = config;
        }

        public object? Login(LoginDto param)
        {
            var user = _users.FirstOrDefault(x => x.account == param.account && x.password == param.password);
            if (user == null) return null;

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.account),
                new Claim(ClaimTypes.Role, user.role),
                new Claim("name", user.name),
                new Claim("id", user.id.ToString()),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(8),
                signingCredentials: creds
            );

            return new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                name = user.name,
                account = user.account,
                role = user.role
            };
        }
    }
}
