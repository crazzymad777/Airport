using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airport
{
    [Table("Ticket")]
    class TicketModel
    {
        [Key]
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Middle_name { get; set; }
        public string Last_name { get; set; }

        public string getFullname()
        {
            return Last_name + " " + First_name + " " + Middle_name;
        }
    }
}
