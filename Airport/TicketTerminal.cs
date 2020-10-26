using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class TicketTerminal
    {
        private DataCenter datacenter;
        public TicketTerminal(DataCenter dc)
        {
            datacenter = dc;
        }
        public void passData(Int32 ticket_number, string full_name)
        {
            // Проверяем введённые данные
            if (datacenter.check_ticket_data(ticket_number, full_name))
            {
                // Всё ок, выдаём талон
                DateTime localDate = DateTime.Now;
                datacenter.insertTicket(ticket_number, full_name, localDate);
                Console.WriteLine($"Талон выдан {localDate}, номер билета: {ticket_number}");
            }
            else
            {
                // Что-то пошло не так, выводим ошибку
                Console.WriteLine($"Ошибка: введены неправильные данные (Номер билета: {ticket_number}, ФИО: {full_name})");
            }
        }
    }
}
