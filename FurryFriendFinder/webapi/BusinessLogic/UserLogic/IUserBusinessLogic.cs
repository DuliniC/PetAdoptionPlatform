using webapi.Common.DTO.User;

namespace webapi.BusinessLogic.UserLogic
{
    public interface IUserBusinessLogic
    {
        Task CreateUser(UserAddDto user);
    }
}
