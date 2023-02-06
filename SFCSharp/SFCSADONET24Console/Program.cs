using System;
using System.Data;
using SFCSADONET24;
using static SFCSADONET24.MainConnector;

namespace SFCSADONET24Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connector = new MainConnector();

            var result = connector.ConnectAsync();

            var data = new DataTable();

            if (result.Result)
            {
                Console.WriteLine("Подключено успешно!");

                var db = new DbExecutor(connector);

                var tablename = "NetworkUser";

                Console.WriteLine($"Получаем данные таблицы {tablename}");
                
                data = db.SelectAll(tablename);

                Console.WriteLine($"Данных в таблице {tablename}: {data.Rows.Count}");

                Console.WriteLine("Отключаем БД");
                connector.DisconnectAsync();
            }
            else
            {
                Console.WriteLine("Ошибка подключения!");
            }

            Console.ReadKey();
        }
    }
}
