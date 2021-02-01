using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DTO;
using LibraryManagementSystem.DL;

namespace LibraryManagementSystem.BL
{
    class LoginBL
    {
        LoginDL lgDL = new LoginDL();
        public LoginBL()
        {

        }
        public int VerifyUserData(LoginDTO lg)
        {
            int val = lgDL.VerifyUserfromDB(lg);

            if (val == 1)
            {
                return 1;
            }
            else if (val == 2)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}

