using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace task_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainOperations mainOperations;
        private Client selectedItem;

        ObservableCollection<Client> clients = new ObservableCollection<Client>();
        public MainWindow(string roleName)
        {
            InitializeComponent();
            mainOperations = new MainOperations(roleName);


            if (roleName == "Менеджер")
                AddClientGrid.Visibility = Visibility.Visible;

            ClientsGrid.ItemsSource = clients;
            mainOperations.FillGrid(clients);
        }
        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            mainOperations.SetData(selectedItem);
            SaveChanges.IsEnabled = false;
        }

        private void ClientsGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            SaveChanges.IsEnabled = true;
        }

        private void ClientsGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            selectedItem = (Client)ClientsGrid.SelectedItem;
        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client()
            {
                Id = ClientsGrid.Items.Count,
                LastName = LastNameTB.Text,
                FirstName = FirstNameTB.Text,
                SecondName = SecondNameTB.Text,
                PhoneNumber = Convert.ToUInt64(PhoneTB.Text),
                PassportNumber = PassportTB.Text
            };
            mainOperations.AddData(clients, client);
        }
    }
}
