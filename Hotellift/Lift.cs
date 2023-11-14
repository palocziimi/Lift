using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotellift
{
    internal class Lift
    {
        DateTime datum;
        int kartyaszam, kezdo, veg;

        public Lift(DateTime datum, int kartyaszam, int kezdo, int veg)
        {
            this.datum = datum;
            this.kartyaszam = kartyaszam;
            this.kezdo = kezdo;
            this.veg = veg;
        }

        public DateTime Datum { get => datum; set => datum = value; }
        public int Kartyaszam { get => kartyaszam; set => kartyaszam = value; }
        public int Kezdo { get => kezdo; set => kezdo = value; }
        public int Veg { get => veg; set => veg = value; }

        public static List<Lift> Beolvas(string filename)
        {
            List<Lift> lista = new List<Lift>();
            StreamReader sr = new StreamReader(filename);
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(' ');
                lista.Add(new Lift(Convert.ToDateTime(line[0]), Convert.ToInt32(line[1]), Convert.ToInt32(line[2]), Convert.ToInt32(line[3])));
            }
            sr.Close();
            return lista;
        }
    }
}
