using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Robot
    {
        // Member Variables 
        public string robotName;
        public bool isAlive; //Health
        public string powerLevel;
        public string robotWeaponType;
        public int robotWeaponAttackPower;


        // Constructor
        public Robot(string robotName, string robotWeaponType, int robotWeaponAttackPower, string powerLevel, bool isAlive)
        {
       
            this.robotName = robotName;
            this.powerLevel = powerLevel;
            this.robotWeaponAttackPower = robotWeaponAttackPower;
            this.isAlive = isAlive;
            this.robotWeaponType = robotWeaponType;
        }

        // Member Methods
    }
}
