using System;
using System.Collections.Generic;
using System.Text;

// TODO: класс Ticker для хранения билета и который можно будет использовать в ORM.

namespace Airport
{
    class DataCenter
    {
        public struct TokenData
        {
            public int ticket_number { get; set; }
            public string first_name { get; set; }
            public string middle_name { get; set; }
            public string last_name { get; set; }
            public string getFullname()
            {
                return last_name + " " + first_name + " " + middle_name;
            }
        }
        public bool check_ticket_data(TokenData token_data)
        {
            // Здесь должно быть обращение к БД.

            if (token_data.ticket_number == 45301)
            {
                if (token_data.last_name == "Москов")
                {
                    if (token_data.first_name == "Юрий")
                    {
                        if (token_data.middle_name == "Алексеевич")
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool insertTicket(TokenData token_data, DateTime datetime)
        {
            // Здесь должно быть добавление записи в БД
            Console.WriteLine($"DataCenter: добавлена запись о талоне ({token_data.ticket_number}, {token_data.getFullname()}, {datetime})");
            return true;
        }
    }
}
