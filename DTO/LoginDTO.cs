using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.BL;
using LibraryManagementSystem.DL;


namespace LibraryManagementSystem.DTO
{

    class LoginDTO
    {
        public LoginDTO()
        {

        }
        private string _username;
        private string _password;

        public string Username
        {
            get => _username;
            set => _username = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }
    }
}
