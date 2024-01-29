using static webapi.Common.Enums;

namespace webapi.Common.DTO.User
{
    public class UserBaseDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserRole UserRole { get; set; }
    }
}
