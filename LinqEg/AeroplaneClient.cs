using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEg
{
    public class AeroplaneClient
    {
        public static List<AeroplaneEg> ae = AeroplaneEg.GetDetails();
        public static void DisplayDetails()
        {
            foreach(var item in ae)
            {
                Console.WriteLine(item.id+" "+item.noofengines+" "+item.Aeroname);
            }
        }
        public static void GetById()
        {
            Console.WriteLine("Enter id: ");
            int id = int.Parse(Console.ReadLine());
            AeroplaneEg ae = AeroplaneEg.GetDetailById(id);
            Console.WriteLine(ae.id + " " + ae.noofengines + " " + ae.Aeroname);
        }
        static void Main()
        {
            DisplayDetails();

            GetById();
            // getdetails()
            //displaydetails()
        }
    }
}
