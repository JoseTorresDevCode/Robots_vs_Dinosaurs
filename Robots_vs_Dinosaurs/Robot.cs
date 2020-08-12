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
        private static int robotWeaponAttackPower;

        // Member Variables 
        public string robotName;
        public bool isAlive; //Health
        public int powerLevel;
        public Weapon weapon;
        public int robotHealth;

        // Constructor
        public Robot(string robotName, string robotWeaponType, int robotWeaponAttackPower, int robotHealth, int powerLevel, bool isAlive)
        {
            this.weapon = new Weapon(robotWeaponType, robotWeaponAttackPower);
            this.robotName = robotName;
            this.powerLevel = powerLevel;
            this.isAlive = isAlive;
            this.robotHealth = robotHealth;
        }

        // Member Methods

        public void AttackDinosaur(Dinosaur attackDinosaur)
        {
            //create attack - pulling health from dinosaur class
            attackDinosaur.dinosaurHealth = attackDinosaur.dinosaurHealth - Robot.robotWeaponAttackPower;
            Console.WriteLine($"{robotName} strikes: {attackDinosaur.type} Damage: {robotWeaponAttackPower}");
            //need if statements for isAlive
            if(attackDinosaur.dinosaurHealth <= 0)
            {
                isAlive = false;
                Console.WriteLine($"{attackDinosaur.type} has died");
            }
        }


    }
}
