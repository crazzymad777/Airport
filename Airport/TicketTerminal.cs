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
        public void passData(DataCenter.TokenData token_data)
        {
            // Проверяем введённые данные
            if (datacenter.check_ticket_data(token_data))
            {
                // Всё ок, выдаём талон
                DateTime localDate = DateTime.Now;
                datacenter.insertTicket(token_data, localDate);
                Console.WriteLine($"Талон выдан {localDate}, номер билета: {token_data.ticket_number}");
            }
            else
            {
                // Что-то пошло не так, выводим ошибку
                Console.WriteLine($"Ошибка: введены неправильные данные (Номер билета: {token_data.ticket_number}, ФИО: {token_data.getFullname()})");
            }
        }
    }
}
