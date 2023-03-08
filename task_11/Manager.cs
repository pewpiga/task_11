using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    class Manager : Consultant, IManager
    {
        public string editor { get; set; }
        public Manager()
        {
            base.editor = "Manager";
            editor = "Manager";
        }
        /// <summary>
        /// Метод для изменения Ф.И.О. клиента
        /// </summary>
        /// <param name="client">Клиент, у которого необходимо сменить ФИО</param>
        /// <param name="lastName">Новая фамилия</param>
        /// <param name="firstName">Новая имя</param>
        /// <param name="secondName">Новое отчество</param>
        public void SetFullName(Client client, string lastName, string firstName, string secondName)
        {
            if (client.LastName != lastName)
            {
                client.ChangeLog.Add(new ChangeLog(DateTime.Now, "LastName", client.LastName, lastName, editor));
            }
            client.LastName = lastName;

            if (client.FirstName != firstName)
            {
                client.ChangeLog.Add(new ChangeLog(DateTime.Now, "FirstName", client.FirstName, firstName, editor));
            }
            client.FirstName = firstName;

            if (client.SecondName != secondName)
            {
                client.ChangeLog.Add(new ChangeLog(DateTime.Now, "SecondName", client.SecondName, secondName, editor));
            }
            client.SecondName = secondName;
        }
        /// <summary>
        /// Метод для изменения паспорта клиента
        /// </summary>
        /// <param name="client">Клиент, у которого меняем номер паспорта</param>
        /// <param name="passportNumber">Новый номер паспорта</param>
        public void SetPassportNumber(Client client, string passportNumber)
        {
            if (client.PassportNumber != passportNumber)
            {
                client.ChangeLog.Add(new ChangeLog(DateTime.Now, "Passport", client.PassportNumber, passportNumber, editor));
            }
            client.PassportNumber = passportNumber;
        }
        /// <summary>
        /// Метод для добавления нового клиента
        /// </summary>
        /// <param name="clients">Коллекция клиентов в которую будем добавлять нового клиента</param>
        /// <param name="client">Клиент, которого будем добавлять</param>
        public void AddNewClient(ObservableCollection<Client> clients, Client client)
        {
            clients.Add(client);
        }
    }
}
