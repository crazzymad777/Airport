using System;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём объекты Терминала выдачи талонов и Центра сбора данных
            DataCenter data_center = new DataCenter();
            TicketTerminal ticket_terminal = new TicketTerminal(data_center);

            // Считываем с консоли ФИО и номер билета
            DataCenter.TokenData token_data = new DataCenter.TokenData();

            Console.WriteLine("Введите номер билета: ");
            token_data.ticket_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Фамилию: ");
            token_data.last_name = Console.ReadLine();
            Console.WriteLine("Введите Имя: ");
            token_data.first_name = Console.ReadLine();
            Console.WriteLine("Введите Отчество: ");
            token_data.middle_name = Console.ReadLine();

            // Передать значения в объект Терминала выдачи талонов
            ticket_terminal.passData(token_data);
        }
    }
}
