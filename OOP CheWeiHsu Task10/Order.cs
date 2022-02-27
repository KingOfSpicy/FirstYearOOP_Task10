using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task10
{
    class Order
    {
        public Order(int id, Guid orderNumber, int clientId)
        {
            Id = id;
            OrderNumber = orderNumber;
            ClientId = clientId;
        }

        public int Id { get; set; }
        public Guid OrderNumber { get; set; }
        public int ClientId { get; set; }
    }
}
