using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_LINQ
{
   public class Animal
    {
        public Species Species { get; set; }

        public Animal(Species species)
        {
            this.Species = species;
        }
    }
}
