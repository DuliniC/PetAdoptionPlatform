using webapi.Common.DTO.User;
using webapi.Models.Entities;
using webapi.UnitOfWork;

namespace webapi.BusinessLogic.UserLogic
{
    public class UserBusinessLogic : IUserBusinessLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserBusinessLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateUser(UserAddDto user)
        {

            var newUser = new User
            {
                UserName = user.UserName,
                Email = user.Email,
                UserRole = user.UserRole,
                Password = user.Password
            };

            _unitOfWork.UserRepository.Add(newUser);
            _unitOfWork.Save();
        }
    }
}
