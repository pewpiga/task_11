using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    class Client
    {
        public int Id { get; set; }
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ulong PhoneNumber { get; set; }
        public string PassportNumber { get; set; }
        public List<ChangeLog> ChangeLog { get; set; }
        public Client() 
        { 
            ChangeLog = new List<ChangeLog>();
        }
    }
}
