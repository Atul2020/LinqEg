using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEg
{
    public class AeroplaneEg
    {
        public string Aeroname { get; set; }
        public int id { get; set; }
        public int noofengines { get; set; }

        public AeroplaneEg() { }
        public AeroplaneEg(string aeroname, int id, int noofengines)
        {
            Aeroname = aeroname;
            this.id = id;
            this.noofengines = noofengines;
        }
        public static List<AeroplaneEg> a = new List<AeroplaneEg>();
        public static List<AeroplaneEg> GetDetails()
        {
            a.Add(new AeroplaneEg("airindia", 1, 2));
            a.Add(new AeroplaneEg("emirates", 2, 4));
            return a;
        }
        public static AeroplaneEg GetDetailById(int aid)
        {
            AeroplaneEg ae = (from i in a
                              where i.id == aid
                              select i).SingleOrDefault();
            return ae;
        }
    }
}
