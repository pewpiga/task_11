using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    class Employee
    {
        private Client _client;
        public Employee()
        {
            _client = new Client();
        }
        /// <summary>
        /// Метод, возвращающий информацию о клиенте
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Client GetClientData(Client client)
        {
            _client.SecondName = client.SecondName;
            _client.FirstName = client.FirstName;
            _client.LastName = client.LastName;
            _client.PhoneNumber = client.PhoneNumber;
            if (client.PassportNumber != null)
                _client.PassportNumber = "******************";
            else
                _client.PassportNumber = "";
            return _client;
        }
    }
}
