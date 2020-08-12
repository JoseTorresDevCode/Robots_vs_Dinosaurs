using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Fleet
    {
        // Member Variables 
        public List<Robot> robots = new List<Robot>();


        // Constructor

        public Fleet()
        {
            Robot c3PO = new Robot("C-3PO","Laser Gun", 8,100,100, true);
            Robot chappie = new Robot("Chappie","M249", 7, 100,100,true);
            Robot terminator = new Robot("T-800", "Bazooka", 12, 100,100,true);


            robots.Add(c3PO);
            robots.Add(chappie);
            robots.Add(terminator);

        }

        // Member Methods
    }  
}
