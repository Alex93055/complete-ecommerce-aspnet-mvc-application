using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Order
    {

        [Key]

        public int Id { get; set; }

        public string Emails { get; set; }

        public string UserId { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
