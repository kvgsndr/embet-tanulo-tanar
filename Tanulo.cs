using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola
{
    class Tanulo :Ember
    {
        string elozoIskola;
        int hianyzottNapok;
        public override void getCel()
        {
            Console.WriteLine("Túljutni az érettségin! ");
        }

        public override void Bemutatkozik()
        {
            Console.WriteLine("Szia, {0} vagyok, {1} éves {2}, a(z) {3} intézményéből jöttem, {4} napot hiányoztam eddig.\n", nev, kor, nem, elozoIskola, hianyzottNapok);

        }

        public Tanulo() : base()
        {
            elozoIskola = "Türr István";
            hianyzottNapok = 10;
        }

    }
}
