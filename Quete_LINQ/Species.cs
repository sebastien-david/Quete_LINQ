using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_LINQ
{
    public class Species
    {

        public String Name { get; set; }
        public bool Protegee { get; set; }

        public Species (String name, bool protegee)
        {
            this.Name = name;
            this.Protegee = protegee;
        }
    }
}
