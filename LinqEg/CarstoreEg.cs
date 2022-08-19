using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEg
{
    //Sample comment
    public class CarstoreEg
    {
        public string Carname { get; set; }
        public int Carid { get; set; }
        public string CarModel { get; set; }

        public CarstoreEg() { }
        public CarstoreEg(string Carname,int Carid,string CarModel)
        {
            this.Carname = Carname;
            this.Carid = Carid;
            this.CarModel = CarModel;
        }
        public static List<CarstoreEg> c = new List<CarstoreEg>();
        public static List<CarstoreEg> GetCarDetails()
        {
            c.Add(new CarstoreEg("Hyundai", 1, "i20"));
            c.Add(new CarstoreEg("Mercedes", 2, "C-class"));
            c.Add(new CarstoreEg("Jaguar", 3, "XJ"));
            return c;
        }
        public static CarstoreEg GetCarById(int id)
        {
            CarstoreEg res = (from i in c
                              where i.Carid == id
                              select i).SingleOrDefault();
            return res;
        }
        public override string ToString()
        {
            return string.Format(Carname + " " + Carid + " " + CarModel);
        }
    }
}
