using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 



namespace Domain
{
    public class UserModel
    {
      
            UserDao userDao = new UserDao();
            public bool LoginUser()
        {
            return userDao.Login();
        }

        

    }
}
