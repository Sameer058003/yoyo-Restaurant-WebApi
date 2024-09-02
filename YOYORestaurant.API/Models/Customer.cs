using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YOYORestaurant.API.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string DeliveryMethod { get; set; }
        public string Amount { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;

    }
}