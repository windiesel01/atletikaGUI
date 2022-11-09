using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atletikaGUI
{
    internal class versenyszamok
    {
        readonly string versenySzam;
        public string VersenySzam => versenySzam;

        public versenyszamok(string versenySzam)
        {
            this.versenySzam = versenySzam;
        }

        public override string ToString()
        {
            return versenySzam;
        }
    }
}
