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
        public List<Dinosaur> dinosaurs = new List<Dinosaur>();
       
        // Constructor

        public Herd()
        {
           Dinosaur tRex = new Dinosaur("Tyrannosaurus",100, true, 100, 12);
           Dinosaur deiny = new Dinosaur("Deinonychus",100,true, 100, 8);
           Dinosaur allo= new Dinosaur("Allosaurus",100, true, 100, 7);

            dinosaurs.Add(tRex);
            dinosaurs.Add(deiny);
            dinosaurs.Add(allo);
            


        }

        // Member Methods


    }
        
}
