using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DTO
{
    class AdminDTO
    {
        public AdminDTO()
        {

        }
        private int _id;
        private int _bookid;
        private string _bookname;
        private string _author;

        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public int Book_Id
        {
            get => Book_Id;
            set => Book_Id = value;
        }

        public string Book_Name
        {
            get => _bookname;
            set => _bookname = value;
        }

    }
}
