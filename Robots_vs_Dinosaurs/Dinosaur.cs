using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Dinosaur
    {
        // Member Variables 
        public string type; //type
        public bool isAlive;      //Health
        public double dinosaurEnergyLevel;
        public double dinosaurAttackPower;
        public Dinosaur(string type, bool isAlive, double dinosaurEnergyLevel, double dinosaurAttackPower)
        // Constructor
        {
            this.isAlive = isAlive;
            this.dinosaurEnergyLevel = dinosaurEnergyLevel;
            this.dinosaurAttackPower = dinosaurAttackPower;
            this.type = type;
        }


        // Member Methods

    }
}
