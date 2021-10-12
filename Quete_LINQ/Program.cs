using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quete_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();
            List<Species> especeList = new List<Species>();

            Species cougarBlanc = new Species("Cougar blanc", true);
            Species tigreBlanc = new Species("Tigre blanc", true);
            Species tortueAlbinos = new Species("Tortue albinos", true);
            Species chatCommun = new Species("chat", false);
            Species chienCommun = new Species("chien", false);
            especeList.Add(cougarBlanc);
            especeList.Add(tigreBlanc);
            especeList.Add(tortueAlbinos);
            especeList.Add(chatCommun);
            especeList.Add(chienCommun);


            for(int i = 0; i < 3; i++)
            {                
                Animal cougar = new Animal(cougarBlanc);
                animalList.Add(cougar);
            }

            for(int i = 0; i < 100; i++)
            {
                Animal tigre = new Animal(tigreBlanc);
                animalList.Add(tigre);
            }

            for(int i = 0; i < 15; i++)
            {
                Animal tortue = new Animal(tortueAlbinos);
                animalList.Add(tortue);
            }

            for(int i = 0; i < 1000; i++)
            {
                Animal chat = new Animal(chatCommun);
                animalList.Add(chat);
            }

            for(int i = 0; i < 2000; i++)
            {
                Animal chien = new Animal(chienCommun);
                animalList.Add(chien);

            }

            string title = $" ***** Recensement des espèces protégées *****";
            string message = "";
            List<Animal> especeProtegeeList = animalList.Where(animal => animal.Species.Protegee).ToList();
            int totalProtectedCount = especeProtegeeList.Count;

            string message1 = $" Il y a actuellement {totalProtectedCount} espèces protégées dans le monde.\n";

            var speciesProtectedCount = especeProtegeeList.GroupBy(e => e.Species.Name).Select(name => name.ToList()).ToList();

            foreach (var espece in speciesProtectedCount)
            {
                message += $" Il reste {espece.Count} {espece[0].Species.Name}.\n";
            }
            
            string message2 = $" Il reste {cougarBlanc} Cougars blancs.";
            string message3 = $" Il reste {tigreBlanc} tigres blancs.";
            string message4 = $" Il reste {tortueAlbinos} tortues albinos.";

           MessageBox.Show(message1 + message, title);
            
        }

    }
}
