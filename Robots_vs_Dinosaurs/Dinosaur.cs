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
        public bool isAMeatEater; //type
        public bool isAlive;      //Health
        public double dinosaurEnergyLevel;
        public double dinosaurAttackPower;
        // Constructor

        public Dinosaur(double dinosaurEnergyLevel, double dinosaurAttackPower, bool isAlive, bool isAMeatEater)
        {

            isAlive = true;
            dinosaurEnergyLevel = 100;
            isAMeatEater = true;
            dinosaurAttackPower = 4;
            this.isAlive = isAlive;
            this.dinosaurEnergyLevel = dinosaurEnergyLevel;
            this.dinosaurAttackPower = dinosaurAttackPower;
            this.isAMeatEater = isAMeatEater;



        }


        // Member Methods

    }
}
