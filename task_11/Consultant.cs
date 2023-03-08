using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    class Consultant : Employee, IConsultant
    {
        public string editor { get; set; }
        public Consultant()
        {
            editor = "Consultant";
        }
        /// <summary>
        /// Метод для изменения номера телефона клиента
        /// </summary>
        /// <param name="client">Клиент, у которого меняем номер телефона</param>
        /// <param name="phoneNubmer">Новый номер телефона</param>
        public void SetPhoneNumber(Client client, ulong phoneNubmer)
        {
            if (client.PhoneNumber != phoneNubmer)
            {
                client.ChangeLog.Add(new ChangeLog(DateTime.Now, "PhoneNumber", Convert.ToString(client.PhoneNumber),
                    Convert.ToString(phoneNubmer), editor));
            }
            client.PhoneNumber = phoneNubmer;
        }
    }
}
