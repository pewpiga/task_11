using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_11;

namespace t10
{
    internal class ClientGenerator
    {
        private ObservableCollection<Client> genClients;
        private Random rand;
        private int count; //количество генерируемых клиентов
        public ClientGenerator(int count)
        {
            genClients = new ObservableCollection<Client>();
            rand = new Random();
            this.count = count;
        }
        public ObservableCollection<Client> ClientListGenerator()
        {
            Client client;
            string phoneNumber;

            for (int i = 0; i < count; i++)
            {
                client = new Client();

                client.Id = i + 1;

                client.LastName = "Фамилия" + rand.Next(0, 8 * i);
                client.FirstName = "Имя" + rand.Next(0, 9 * i);
                client.SecondName = "Отчество" + rand.Next(0, 10 * i);

                phoneNumber = $"7{rand.Next(900, 999)}{rand.Next(1000000, 9999999)}";
                client.PhoneNumber = Convert.ToUInt64(phoneNumber);

                client.PassportNumber = $"{rand.Next(1000, 9999)} {rand.Next(100000, 999999)}";

                genClients.Add(client);
            }
            return genClients;
        }
    }
}