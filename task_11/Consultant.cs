using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    class Consultant : Employee
    {
        /// <summary>
        /// Метод для изменения номера телефона клиента
        /// </summary>
        /// <param name="client">Клиент, у которого меняем номер телефона</param>
        /// <param name="phoneNubmer">Новый номер телефона</param>
        public void SetPhoneNumber(Client client, ulong phoneNubmer)
        {
            client.PhoneNumber = phoneNubmer;
        }
    }
}
