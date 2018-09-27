/*
 Name = Simranjit Singh
 Student ID = 30011264
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolesum1
{
    
    
        
        
            
     class Bird
        {
            string name, sound;


            public string Name
            {
                get { return name; }
                set { name = value; }

            }
            public string Sound
            {
                get { return sound; }
                set { sound = value; }

            }
            //public constructor
            public bird(string _name, string _sound)
            {
                Name = _name;
                Sound = _sound;
            }
            //public method that returns a string.
            public string Birdsays()
            {
                return "bird name Hisan " + Name + "and species NZ Falcon" + Sound;
            

            }
            class program
            {
                static void Main(string[] args)
                {
                    Console.Write("please enter the bird name:Hisan");
                    string birdtype = Console.ReadLine();
                    Console.Write("please enter the bird species:NZ Falcon");
                    string birdSound = Console.ReadLine();

                    bird first = new bird(birdtype, birdSound);

                    Console.WriteLine(first.Birdsays());
                }


            }




        }
}

