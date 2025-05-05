using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class UI
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();

        public UI()
        {
            AllocConsole();
        }

        public void Start()
        {
            while (true) {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Показать все аэропорты");
                Console.WriteLine("2 - Добавить новый аэропорт");
                Console.WriteLine("3 - Изменить аэропорт");
                Console.WriteLine("4 - Удалить аэропорт");
                Console.WriteLine("5 - Выход");

                var value = Console.ReadLine();
                switch (value)
                {
                    case "1":
                        ShowAll();
                        break;
                    case "2":
                        AddAirport();
                        break;
                    case "3":
                        UpdateAirport();
                        break;
                    case "4":
                        DeleteAirport();
                        break;
                    case "5":
                        Stop();
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод");
                        break;
                }
            }
        }

        public void ShowAll()
        {
            Console.Clear();

            foreach (var i in new List<Airport>())
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("Введите back чтобы вернуться назад");
            while (true)
            {
                var comand = Console.ReadLine();

                if (comand == "back")
                {
                    Console.Clear();
                    return;
                }

                Console.Clear();
                Console.WriteLine("Неизвестная команда");
            }
        }

        public void AddAirport()
        {

        }

        public void UpdateAirport()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Введите название аэропорта(back - назад)");

                var name = Console.ReadLine();

                if (name == "back")
                {
                    Console.Clear();
                    return;
                }

                if (name == null)
                {
                    Console.Clear();
                    Console.WriteLine("Аэропорт с таким именем не найден");
                    continue;
                }
            }
        }

        public void DeleteAirport()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Введите название аэропорта(back - назад)");

                var name = Console.ReadLine();

                if (name == "back")
                {
                    Console.Clear();
                    return;
                }

                var airport = new Airport();

                if (airport == null)
                {
                    Console.Clear();
                    Console.WriteLine("Аэропорт с таким именем не найден");

                    continue;
                }
            }
        }

        public void Stop()
        {
            FreeConsole();
        }
    }
}
