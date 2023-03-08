using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using t10;

namespace task_11
{
    class MainOperations
    {
        private string roleName;
        private ObservableCollection<Client> clientsList;
        private ReadWrite rw;
        private ClientGenerator generator;
        public Employee Role { get; set; }
        public MainOperations(string roleName)
        {
            this.roleName = roleName;
            SelectRole();

            clientsList = new ObservableCollection<Client>();
            rw = new ReadWrite("clients.json");

            //Раскомментировать, если необходимо сгенерировать клиентов
            //generator = new ClientGenerator(30);
            //rw.Write(generator.ClientListGenerator());

            clientsList = rw.Read();
        }
        /// <summary>
        /// Выбор роли сотрудника
        /// </summary>
        private void SelectRole()
        {
            if (roleName == "Консультант")
                Role = new Consultant();
            else if (roleName == "Менеджер")
                Role = new Manager();
        }
        /// <summary>
        /// Замена ********* на нормальный номер при записи в json
        /// </summary>
        /// <param name="client"></param>
        /// <param name="clientPassport"></param>
        /// <returns></returns>
        private string CheckPassport(Client client, string clientPassport)
        {
            string passport;
            if (clientPassport.StartsWith("*") || clientPassport.EndsWith("*"))
                passport = client.PassportNumber;
            else
                passport = clientPassport;
            return passport;
        }
        /// <summary>
        /// Заполнение Grid
        /// </summary>
        /// <param name="clients">Коллекция, которую заполняем</param>
        public void FillGrid(ObservableCollection<Client> clients)
        {
            foreach (Client client in clientsList)
            {
                clients.Add(Role.GetClientData(client));
            }
        }
        /// <summary>
        /// Изменение данных
        /// </summary>
        /// <param name="client">Клиент, которому меняем данные</param>
        public void SetData(Client client)
        {
            foreach(var item in clientsList)
            {
                if (item.Id == client.Id)
                {
                    string passportNumber = CheckPassport(item, client.PassportNumber);
                    if (roleName == "Консультант")
                    {
                        (Role as Consultant).SetPhoneNumber(item, client.PhoneNumber);
                    }
                    else if (roleName == "Менеджер")
                    {
                        (Role as Manager).SetPhoneNumber(item, client.PhoneNumber);
                        (Role as Manager).SetFullName(item, client.LastName, client.FirstName, client.SecondName);                        
                        (Role as Manager).SetPassportNumber(item, passportNumber);
                    }
                }
            }
            rw.Write(clientsList);
        }
        /// <summary>
        /// Добавление новых данных в коллекцию
        /// </summary>
        /// <param name="clients">Коллекция, куда добавляем</param>
        /// <param name="client">Данные которые добавляем</param>
        public void AddData(ObservableCollection<Client> clients, Client client)
        {
            clients = clientsList;
            (Role as Manager).AddNewClient(clientsList, client);
            rw.Write(clients);
        }
    }
}
