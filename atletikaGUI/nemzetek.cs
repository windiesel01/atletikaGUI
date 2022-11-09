using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atletikaGUI
{
    internal class nemzetek
    {
        readonly string nemzet;
        public string Nemzet => nemzet;

        public nemzetek(string nemzet)
        {
            this.nemzet = nemzet;
        }

        public override string ToString()
        {
            return nemzet;
        }
    }
}
