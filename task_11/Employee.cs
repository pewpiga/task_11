using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    abstract class Employee
    {
        public Employee()
        {
        }
        /// <summary>
        /// Метод, возвращающий информацию о клиенте
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Client GetClientData(Client client)
        {
            Client _client = new Client();

            _client.Id = client.Id;
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
