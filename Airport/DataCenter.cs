using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public void seedTestData()
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();

                var testTicket = context.Tickets.First();
                if (testTicket == null)
                {
                    context.Tickets.Add(new TicketModel
                    {
                        Id = 45301,
                        First_name = "Юрий",
                        Middle_name = "Алексеевич",
                        Last_name = "Москов"
                    });
                }
                context.SaveChanges();
            }
        }
        public bool check_ticket_data(TokenData token_data)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                TicketModel ticketModel = context.Tickets.Find(token_data.ticket_number);

                if (ticketModel != null)
                {
                    if (token_data.ticket_number == ticketModel.Id)
                    {
                        if (token_data.last_name == ticketModel.Last_name)
                        {
                            if (token_data.first_name == ticketModel.First_name)
                            {
                                if (token_data.middle_name == ticketModel.Middle_name)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool insertTicket(TokenData token_data, DateTime datetime)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                context.Tokens.Add(new TokenModel()
                {
                    First_name = token_data.first_name,
                    Middle_name = token_data.middle_name,
                    Last_name = token_data.last_name,
                    Time = datetime.ToString(),
                    Ticket_number = token_data.ticket_number
                });
                context.SaveChanges();
            }
            Console.WriteLine($"DataCenter: добавлена запись о талоне ({token_data.ticket_number}, {token_data.getFullname()}, {datetime})");
            return true;
        }
    }
}
