using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task10
{
    class AllOrderProducts:List<OrderProduct>

    {
        public AllOrderProducts()
        {
            DateTime today = DateTime.Now;
            //Donald Duck
            Add(new OrderProduct(1, 3, true, today.AddMonths(-2).AddDays(1), 1, 1));
            Add(new OrderProduct(2, 3, true, today.AddMonths(-2).AddDays(1), 1, 8));
            //Bigtime Beagle
            Add(new OrderProduct(3, 2, false, today.AddMonths(1).AddDays(1), 2, 2));
            Add(new OrderProduct(4, 2, false, today.AddMonths(1).AddDays(1), 2, 9));
            Add(new OrderProduct(5, 2, true, today.AddMonths(-1).AddDays(1), 2, 11));
            //Droofus Drake
            Add(new OrderProduct(6, 4, true, today.AddMonths(-2).AddDays(1), 3, 3));
            Add(new OrderProduct(7, 4, true, today.AddMonths(-2).AddDays(1), 3, 10));
            Add(new OrderProduct(8, 4, false, today.AddMonths(1).AddDays(2), 3, 12));
            //Elmer Elephant
            Add(new OrderProduct(9, 1, false, today.AddMonths(1).AddDays(3), 4, 4));
            Add(new OrderProduct(10, 1, false, today.AddMonths(1).AddDays(3), 4, 11));
            //Mickey Mouse
            Add(new OrderProduct(11, 1, true, today.AddMonths(-2).AddDays(4), 5, 5));
            Add(new OrderProduct(12, 1, true, today.AddMonths(-2).AddDays(4), 5, 12));
            //Ludvig von Drake
            Add(new OrderProduct(13, 4, true, today.AddMonths(-2).AddDays(5), 6, 6));
            Add(new OrderProduct(14, 4, true, today.AddMonths(-2).AddDays(5), 6, 13));
            //Gyro Gearloose
            Add(new OrderProduct(15, 5, false, today.AddMonths(1).AddDays(4), 7, 7));
            Add(new OrderProduct(16, 5, false, today.AddMonths(1).AddDays(4), 7, 14));
            //Scrooge McDuck
            Add(new OrderProduct(17, 2, true, today.AddMonths(-2).AddDays(6), 8, 8));
            Add(new OrderProduct(18, 2, true, today.AddMonths(-2).AddDays(6), 8, 15));
            //Minnie Mouse
            Add(new OrderProduct(19, 2, true, today.AddMonths(-2).AddDays(6), 9, 7));
            Add(new OrderProduct(20, 2, true, today.AddMonths(-2).AddDays(6), 9, 16));
            //Big Bad Wolf
            Add(new OrderProduct(21, 1, true, today.AddMonths(-2).AddDays(7), 10, 6));
            Add(new OrderProduct(22, 1, true, today.AddMonths(-2).AddDays(7), 10, 17));
            //Mortimer Mouse
            Add(new OrderProduct(23, 3, false, today.AddMonths(1).AddDays(5), 11, 5));
            Add(new OrderProduct(24, 3, false, today.AddMonths(1).AddDays(5), 11, 15));
            //Lil Bad Wolf
            Add(new OrderProduct(25, 1, true, today.AddMonths(-2).AddDays(7), 12, 4));
            Add(new OrderProduct(26, 1, true, today.AddMonths(-2).AddDays(7), 12, 14));
            //Gosalyn Loosey
            Add(new OrderProduct(27, 5, false, today.AddMonths(1).AddDays(6), 13, 3));
            Add(new OrderProduct(28, 5, false, today.AddMonths(1).AddDays(6), 13, 13));
            //Gus Goose
            Add(new OrderProduct(29, 4, true, today.AddMonths(-2).AddDays(8), 14, 2));
            Add(new OrderProduct(30, 4, true, today.AddMonths(-2).AddDays(8), 14, 12));
            //Honker Muddlefoot
            Add(new OrderProduct(31, 3, true, today.AddMonths(-2).AddDays(7), 15, 1));
            Add(new OrderProduct(32, 3, true, today.AddMonths(-2).AddDays(7), 15, 11));
            Add(new OrderProduct(33, 3, true, today.AddMonths(-2).AddDays(7), 15, 17));
            //Horace Horcecollar
            Add(new OrderProduct(34, 2, true, today.AddMonths(-2).AddDays(6), 16, 2));
            Add(new OrderProduct(35, 2, true, today.AddMonths(-2).AddDays(6), 16, 10));
            //Gladstone Gander
            Add(new OrderProduct(36, 3, true, today.AddMonths(-2).AddDays(5), 17, 3));
            Add(new OrderProduct(37, 3, true, today.AddMonths(-2).AddDays(5), 17, 9));
            //Flintheart Glomgold
            Add(new OrderProduct(38, 3, true, today.AddMonths(-2).AddDays(4), 18, 4));
            Add(new OrderProduct(39, 5, false, today.AddMonths(1).AddDays(5), 18, 8));
            Add(new OrderProduct(40, 5, false, today.AddMonths(1).AddDays(5), 18, 6));
            //Fiddler Pig
            Add(new OrderProduct(41, 2, false, today.AddMonths(1).AddDays(4), 19, 5));
            Add(new OrderProduct(42, 2, false, today.AddMonths(1).AddDays(4), 19, 4));
            //Add(newton Gearloose
            Add(new OrderProduct(43, 2, false, today.AddMonths(1).AddDays(3), 20, 3));
            Add(new OrderProduct(44, 2, false, today.AddMonths(1).AddDays(3), 20, 2));
            //Bouncer Beagle
            Add(new OrderProduct(45, 4, true, today.AddMonths(-2).AddDays(3), 21, 1));
            Add(new OrderProduct(46, 1, true, today.AddMonths(-2).AddDays(3), 21, 17));
            //Clara Cluck
            Add(new OrderProduct(47, 6, true, today.AddMonths(-2).AddDays(9), 22, 16));
            Add(new OrderProduct(48, 5, true, today.AddMonths(-2).AddDays(9), 22, 15));
        }
    }
}
