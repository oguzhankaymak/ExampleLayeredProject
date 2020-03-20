using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        User GetUserByUsername(string username);
        bool IsUserControl(string username, string password);
    }
}
