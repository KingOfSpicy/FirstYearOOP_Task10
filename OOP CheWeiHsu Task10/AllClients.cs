using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task10
{
    class AllClients:List<Client>
    {
        public AllClients()
        {
            Add(new Client(1, "Donald Duck", "Porvoo", Client.Countries.Finland));
            Add(new Client(2, "Bigtime Beagle", "Stockholm", Client.Countries.Sweden));
            Add(new Client(3, "Droofus Drake", "Oslo", Client.Countries.Norway));
            Add(new Client(4, "Elmer Elephant", "Espoo", Client.Countries.Finland));
            Add(new Client(5, "Mickey Mouse", "Helsinki", Client.Countries.Finland));
            Add(new Client(6, "Ludwig von Drake", "Gothenburg", Client.Countries.Sweden));
            Add(new Client(7, "Gyro Gearloose", "Bergen", Client.Countries.Norway));
            Add(new Client(8, "Scrooge McDuck", "Reykjavik", Client.Countries.Iceland));
            Add(new Client(9, "Minnie Mouse", "Mikkeli", Client.Countries.Finland));
            Add(new Client(10, "Big Bad Wolf", "Sandviken", Client.Countries.Sweden));
            Add(new Client(11, "Mortimer Mouse", "Lillehammer", Client.Countries.Norway));
            Add(new Client(12, "Lil Bad Wolf", "Trondheim", Client.Countries.Norway));
            Add(new Client(13, "Gosalyn Loosey", "Kotka", Client.Countries.Finland));
            Add(new Client(14, "Gus Goose", "Stavanger", Client.Countries.Norway));
            Add(new Client(15, "Honker Muddlefoot", "Ronneby", Client.Countries.Sweden));
            Add(new Client(16, "Horace Horsecollar", "Keflavik", Client.Countries.Iceland));
            Add(new Client(17, "Gladstone Gander", "Dalvik", Client.Countries.Iceland));
            Add(new Client(18, "Flintheart Glomgold", "Kouvola", Client.Countries.Finland));
            Add(new Client(19, "Fiddler Pig", "Sigtuna", Client.Countries.Sweden));
            Add(new Client(20, "Newton Gearloose", "Sandnes", Client.Countries.Norway));
            Add(new Client(21, "Bouncer Beagle", "Mariestad", Client.Countries.Sweden));
            Add(new Client(22, "Clara Cluck", "Drammen", Client.Countries.Norway));
        }
    }
}
