using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Robot
    {
        // Member Variables 
        public string robotName;
        public bool isAlive; //Health
        public int powerLevel;
        public Weapon weapon;


        // Constructor
        public Robot(string robotName, string robotWeaponType, int robotWeaponAttackPower, int powerLevel, bool isAlive)
        {
            this.weapon = new Weapon(robotWeaponType, robotWeaponAttackPower);
            this.robotName = robotName;
            this.powerLevel = powerLevel;
            this.isAlive = isAlive;
        }

        // Member Methods

       
    }
}
