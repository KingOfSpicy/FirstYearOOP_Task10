using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task10
{
    class AllProducts:List<Product>
    {
        public AllProducts()
        {
                Add(new Product(1, "Cooking Chef", 123.55m));
                Add(new Product(2, "Hand Blender", 55.65m));
                Add(new Product(3, "Citrus Press", 12.95m));
                Add(new Product(4, "Glass Kettle", 32.20m));
                Add(new Product(5, "Garlic Press", 18.35m));
                Add(new Product(6, "Pepper Mill", 22.85m));
                Add(new Product(7, "Thermocouple Thermometer", 116.20m));
                Add(new Product(8, "Oven Glove", 43.45m));
                Add(new Product(9, "Barbecue grill", 165.30m));
                Add(new Product(10, "Blazier", 39.25m));
                Add(new Product(11, "Cheesemelter", 26.95m));
                Add(new Product(12, "Corn roaster", 77.85m));
                Add(new Product(13, "Espresso machine", 279.75m));
                Add(new Product(14, "Pancake machine", 55.65m));
                Add(new Product(15, "Waffle iron", 48.45m));
                Add(new Product(16, "Panini sandwich grill", 111.55m));
                Add(new Product(17, "Swivel Peeler", 29.50m));
        }
    }
}
