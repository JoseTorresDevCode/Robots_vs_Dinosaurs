using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Herd
    {
        // Member Variables 


        public List<Dinosaur> dinosaur = new List<Dinosaur>();
        public Dinosaur tRex;
        public Dinosaur deiny;
        public Dinosaur allo;

        // Constructor

        public Herd()
        {
            tRex = new Dinosaur("Tyrannosaurus", true, 100, 12);
            deiny = new Dinosaur("Deinonychus", true, 100, 8);
            allo = new Dinosaur("Allosaurus", true, 100, 7);

            dinosaur.Add(tRex);
            dinosaur.Add(deiny);
            dinosaur.Add(allo);
            


        }

        // Member Methods


    }
        
}
