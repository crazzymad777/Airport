using System;
using System.Collections.Generic;
using System.Text;

// TODO: класс Ticker для хранения билета и который можно будет использовать в ORM.

namespace Airport
{
    class DataCenter
    {
        public bool check_ticket_data(Int32 ticket_number, string full_name)
        {
            // Здесь должно быть обращение к БД.

            if (ticket_number == 45301)
            {
                if (full_name == "Москов Юрий Алексеевич")
                {
                    return true;
                }
            }
            return false;
        }
        public bool insertTicket(Int32 ticket_number, string full_name, DateTime datetime)
        {
            // Здесь должно быть добавление записи в БД
            Console.WriteLine($"DataCenter: добавлена запись о талоне ({ticket_number}, {full_name}, {datetime})");
            return true;
        }
    }
}
