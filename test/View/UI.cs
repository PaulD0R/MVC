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
            Console.Clear();

            Console.WriteLine("Название: ");
            var name = writeName();

            Console.WriteLine("Число полетов:");
            var countFlight = writeCountFlight();

            Console.WriteLine("Число билетов:");
            var countTicket = writeCountTicket();

            Console.WriteLine("Площадь:");
            var area = writeArea();

            Console.WriteLine("Открыто/Закрыто");
            var isOpen = writeIsOpen();

            Console.WriteLine("Город:");
            var city = writeCity();

            Console.WriteLine("Год открытия:");
            var yearOfConstruction = writeYearOfConstruction();
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

                var airport = new Airport();

                if (airport == null)
                {
                    Console.Clear();
                    Console.WriteLine("Аэропорт с таким именем не найден");
                    continue;
                }

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(airport.ToString());
                    Console.WriteLine("1 - Название");
                    Console.WriteLine("2 - Число полетов");
                    Console.WriteLine("3 - Число билетов");
                    Console.WriteLine("4 - Площадь");
                    Console.WriteLine("5 - Открыто/Закрыто");
                    Console.WriteLine("6 - Город");
                    Console.WriteLine("7 - Год открытия");
                    Console.WriteLine("8 - Сохранить");

                    var value = Console.ReadLine();
                    switch (value)
                    {
                        case "1":
                            airport.Name = writeName();
                            break;
                        case "2":
                            airport.CountFlight = writeCountFlight();
                            break;
                        case "3":
                            airport.CountTicket = writeCountTicket();
                            break;
                        case "4":
                            airport.Area = writeArea();
                            break;
                        case "5":
                            airport.IsOpen = writeIsOpen();
                            break;
                        case "6":
                            airport.City = writeCity();
                            break;
                        case "7":
                            airport.YearOfConstruction = writeYearOfConstruction();
                            break;
                        case "8":
                            return;
                        default:
                            Console.Clear();
                            Console.WriteLine("Неизвестная команда");
                            break;
                    }
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

        public string writeName()
        {
            var name = Console.ReadLine();

            return name;
        }

        public int writeCountFlight()
        {
            while (true)
            {
                var countFlightString = Console.ReadLine();

                if (int.TryParse(countFlightString, out var countFlight)) return countFlight;

                Console.WriteLine("Неверный формат числа полетов");
            }
        }

        public int writeCountTicket()
        {
            while (true)
            {
                var countTicketString = Console.ReadLine();

                if (int.TryParse(countTicketString, out var countTicket)) return countTicket;

                Console.WriteLine("Неверный формат числа билетов");
            }
        }

        public int writeArea()
        {
            while (true)
            {
                var AreaString = Console.ReadLine();

                if (int.TryParse(AreaString, out var area)) return area;

                Console.WriteLine("Неверный формат площади");
            }
        }

        public bool writeIsOpen()
        {
            while (true)
            {
                Console.WriteLine("1 - Открыто");
                Console.WriteLine("0 - Закрыто");
                var isOpen = Console.ReadLine();

                switch (isOpen)
                {
                    case "1":
                        return true;
                    case "0":
                        return false;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;
                }
            }
        }

        public string writeCity()
        {
            var countFlightString = Console.ReadLine();

            return countFlightString;
        }

        public short writeYearOfConstruction()
        {
            while (true)
            {
                var YearOfConstructionString = Console.ReadLine();

                if (short.TryParse(YearOfConstructionString, out var YearOfConstruction)) return YearOfConstruction;

                Console.WriteLine("Неверный формат года открытия");
            }
        }

        public void Stop()
        {
            FreeConsole();
        }
    }
}
