using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airport
{
    [Table("Token")]
    class TokenModel
    {
        [Key]
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Middle_name { get; set; }
        public string Last_name { get; set; }
        public int Ticket_number { get; set; }

        public string Time { get; set; }

        public string getFullname()
        {
            return Last_name + " " + First_name + " " + Middle_name;
        }
    }
}
