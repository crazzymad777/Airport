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
            Console.WriteLine("Введите номер билета: ");
            Int32 ticket_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО: ");
            string full_name = Console.ReadLine();

            ticket_terminal.passData(ticket_number, full_name);
        }
    }
}
