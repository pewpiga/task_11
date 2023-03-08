using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace task_11
{
    internal class ReadWrite
    {
        private string path;
        public ReadWrite(string path)
        {
            this.path = path;
        }
        /// <summary>
        /// Чтение из json файла
        /// </summary>
        /// <returns>Возвращает коллекцию клиентов</returns>
        public ObservableCollection<Client> Read()
        {
            ObservableCollection<Client> clients = new ObservableCollection<Client>();
            JsonSerializer jsonSerializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(path))
            {
                using (JsonTextReader jsonTextReader = new JsonTextReader(sr))
                {
                    while(jsonTextReader.Read())
                    {
                        jsonTextReader.SupportMultipleContent = true;
                        clients.Add(jsonSerializer.Deserialize<Client>(jsonTextReader));
                    }
                }
                sr.Close();
            }
            return clients;
        }
        /// <summary>
        /// Запись в json файл
        /// </summary>
        /// <param name="clients">Принимает коллекцию клиентов для записи в json</param>
        public void Write(ObservableCollection<Client> clients)
        {
            string json = String.Empty;
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var client in clients)
                {
                    json += JsonConvert.SerializeObject(client, Formatting.Indented);
                }
                sw.Write(json);
                sw.Close();
            }
        }
    }
}
