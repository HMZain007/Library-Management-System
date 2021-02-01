using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DTO
{
    class Books
    {

        public Books()
        {
        }

        private int _id;
        private string _name;
        private string _author;

        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Author
        {
            get => _author;
            set => _author = value;
        }


    }
}
