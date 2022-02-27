using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task10
{
    class AllOrders:List<Order>
    {
        public AllOrders()
        {
            Add(new Order(1, Guid.NewGuid(), 1));
            Add(new Order(2, Guid.NewGuid(), 2));
            Add(new Order(3, Guid.NewGuid(), 3));
            Add(new Order(4, Guid.NewGuid(), 4));
            Add(new Order(5, Guid.NewGuid(), 5));
            Add(new Order(6, Guid.NewGuid(), 6));
            Add(new Order(7, Guid.NewGuid(), 7));
            Add(new Order(8, Guid.NewGuid(), 8));
            Add(new Order(9, Guid.NewGuid(), 9));
            Add(new Order(10, Guid.NewGuid(), 10));
            Add(new Order(11, Guid.NewGuid(), 11));
            Add(new Order(12, Guid.NewGuid(), 12));
            Add(new Order(13, Guid.NewGuid(), 13));
            Add(new Order(14, Guid.NewGuid(), 14));
            Add(new Order(15, Guid.NewGuid(), 15));
            Add(new Order(16, Guid.NewGuid(), 16));
            Add(new Order(17, Guid.NewGuid(), 17));
            Add(new Order(18, Guid.NewGuid(), 18));
            Add(new Order(19, Guid.NewGuid(), 19));
            Add(new Order(20, Guid.NewGuid(), 20));
            Add(new Order(21, Guid.NewGuid(), 21));
            Add(new Order(22, Guid.NewGuid(), 22));
        }
    }
}
