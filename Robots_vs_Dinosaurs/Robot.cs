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
        public bool hasPowerLeft;
        public string robotWeaponType;
        public int robotWeaponAttackPower;


        // Constructor
        public Robot(string robotName, string robotWeaponType, int robotWeaponAttackPower, bool hasPowerLeft, bool isAlive)
        {
            isAlive = true;
            robotWeaponType = "";
            hasPowerLeft = true;
            robotWeaponAttackPower = 4;
            robotName = "";
            this.robotName = robotName;
            this.hasPowerLeft = hasPowerLeft;
            this.robotWeaponAttackPower = robotWeaponAttackPower;
            this.isAlive = isAlive;
            this.robotWeaponType = robotWeaponType;
        }

        // Member Methods
    }
}
