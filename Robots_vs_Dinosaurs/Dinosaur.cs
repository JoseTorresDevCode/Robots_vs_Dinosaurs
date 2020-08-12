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
        public int dinosaurHealth; //Health
        public bool isAlive;      
        public int dinosaurEnergyLevel;
        public int dinosaurAttackPower;
        public Dinosaur(string type, int dinosaurHealth, bool isAlive, int dinosaurEnergyLevel, int dinosaurAttackPower)
        // Constructor
        {
            
            this.dinosaurHealth = dinosaurHealth;
            this.isAlive = isAlive;
            this.dinosaurEnergyLevel = dinosaurEnergyLevel;
            this.dinosaurAttackPower = dinosaurAttackPower;
            this.type = type;
        }


        // Member Methods

        public void AttackRobot(Robot attackRobot)
        {
            attackRobot.robotHealth = attackRobot.robotHealth - dinosaurAttackPower;
            Console.WriteLine($"{type} strikes: {attackRobot.robotName} Damage: {dinosaurAttackPower}");
        }
    }
}
