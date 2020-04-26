using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public User GetUserByUsername(string username)
        {
           return _userDal.Get(filter: u => u.Username == username);
        }

        public bool IsUserControl(string username, string password)
        {
            return _userDal.Get(filter: u => u.Username == username && u.Password == password) != null;
        }
    }
}
