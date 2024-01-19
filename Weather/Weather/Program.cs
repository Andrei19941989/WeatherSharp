using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Weather
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Request("Tokyo");
        }

        public static void Request(string City)//функция для отправки запроса-для тлшл чтобы выполнялась в отдельном потоке надо установить тип данных async Task
        {
            string n = "https://api.openweathermap.org/data/2.5/weather?";//адрес сайта
            string key = "5dda6a0fc9669c3d80c62450ee76c3f9";//ключ выдается при регистрации
            using (WebClient client = new WebClient())//подключение к серверу
            {
                string  response = client.DownloadString(n + $"q={City}&appid={key}");//отправка запроса на сервер-await-будет ждать выполнения запроса
              Console.WriteLine(response);
              Weatherclass w = JsonConvert.DeserializeObject<Weatherclass>(response);//конфератция в json в объект класса
              Console.WriteLine(w.name);
            }
            
        }
    }
}