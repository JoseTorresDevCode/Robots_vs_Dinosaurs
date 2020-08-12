using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Battlefield
    {
        // Member Variables (HAS A)
        //fleet and herd
        public Herd herd;
        public Fleet fleet;

        // Constructor
        public Battlefield()
        {
            Fleet fleet = new Fleet();
            Herd herd = new Herd();
            this.fleet = fleet;
            this.herd = herd;
            
        }
        // Member Methods

        //Fleet fleet = new Fleet();
        //Console.WriteLine("The robot named " + fleet.robots[0].robotName + " has a weapon called " + fleet.robots[0].weapon.weaponType);

        public void RunBattle(Dinosaur dinosaur)
        {
            
            
           
            //Display welcome
            Console.WriteLine("Welcome to Robots VS Dinosaurs");
            Console.WriteLine(" " + "WELCOME ROBOTS!!!" + " " + ">>>>" + fleet.robots[0].robotName + " " + "-" + " " + "Weapon:" + fleet.robots[0].weapon.weaponType + "<<<<" + " " + ">>>>" + fleet.robots[1].robotName + " " + "-" + " " + "Weapon:" + fleet.robots[1].weapon.weaponType + "<<<<" + " " + ">>>>" + fleet.robots[2].robotName + " " + "Weapon:" + fleet.robots[2].weapon.weaponType + "<<<<");
            Console.WriteLine(" " + "WELCOME DINOSAURS!!!" + " " + ">>>>" + herd.dinosaurs[0].type + "<<<<" + " " + ">>>>" + herd.dinosaurs[1].type + "<<<<" + " " + ">>>>" + herd.dinosaurs[2].type + "<<<<");
            
            if (fleet.robots.Count > 0 && herd.dinosaurs.Count > 0)
            {
                fleet.robots[Random].AttackDinosaur(herd.dinosaurs[Random]);
                {
                   
                    
                    
                }

            }
            
            
            
            
            
            
            
            
            
            Console.ReadLine();
            

           
        }

       
        
        
        
        
        
        
        
        
        
        //string ChooseAcharachter(string userInput)
        //{
        //    Console.WriteLine(userInput + "Please type in your selection");
        //    userInput = Console.ReadLine();
        //    return userInput;
            
        //}


        



    }
}
