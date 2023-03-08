using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    internal interface IManager
    {
        public void SetFullName(Client client, string lastName, string firstName, string secondName);
        public void SetPassportNumber(Client client, string passportNumber);
        public void AddNewClient(ObservableCollection<Client> clients, Client client);
    }
}
