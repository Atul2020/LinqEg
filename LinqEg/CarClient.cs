using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEg
{
    public class CarClient
    {
        public static List<CarstoreEg> cars = CarstoreEg.GetCarDetails();

        public static void Displayproducts()
        {
            foreach(var item in cars)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void DisplayCarById()
        {
            Console.WriteLine("Enter carid: ");
            int id=int.Parse(Console.ReadLine());
            CarstoreEg c = CarstoreEg.GetCarById(id);
            Console.WriteLine(c.ToString());
        }
        static void main()
        {
            Displayproducts();
            DisplayCarById();

        }
    }
}
