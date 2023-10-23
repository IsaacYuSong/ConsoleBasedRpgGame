using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Race
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public string SpecialAbility { get; set; }
        public static string? raceChosen { get; private set; }

        public Race(string name, int strength, int agility, int intelligence, string specialAbility)
        {
            Name = name;
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
            SpecialAbility = specialAbility;
        }
        public static void ChoosedHuman()
        {
            raceChosen = "Human";
            Race human = new Race("Human", 5, 5, 5, "Adaptability");
            Console.WriteLine("Human");
            Console.WriteLine("-------");
            Console.WriteLine("Name:" + human.Name);
            Console.WriteLine("Strength:" + human.Strength);
            Console.WriteLine("Agility:" + human.Agility);
            Console.WriteLine("Intelligence:" + human.Intelligence);
            Console.WriteLine("Special Ability:" + human.SpecialAbility);
        }
        public static void ChoosedElf()
        {
            raceChosen = "Elf";
            Race elf = new Race("Elf", 3, 7, 6, "Elven Magic");
            Console.WriteLine("Elf");
            Console.WriteLine("-------");
            Console.WriteLine("Name:" + elf.Name);
            Console.WriteLine("Strength:" + elf.Strength);
            Console.WriteLine("Agility:" + elf.Agility);
            Console.WriteLine("Intelligence:" + elf.Intelligence);
            Console.WriteLine("Special Ability:" + elf.SpecialAbility);

        }
        public static void ChoosedDwarf()
        {
            raceChosen = "Dwarf";
            Race dwarf = new Race("Dwarf", 7, 3, 4, "Dwarven Resilience");
            Console.WriteLine("Dwarf");
            Console.WriteLine("-------");
            Console.WriteLine("Name:" + dwarf.Name);
            Console.WriteLine("Strength:" + dwarf.Strength);
            Console.WriteLine("Agility:" + dwarf.Agility);
            Console.WriteLine("Intelligence:" + dwarf.Intelligence);
            Console.WriteLine("Special Ability:" + dwarf.SpecialAbility);

        }
        public static void chooseRace()
        {
            
            Console.WriteLine("Choose Your race");
            Console.WriteLine("1:Human");
            Console.WriteLine("2:Elf");
            Console.WriteLine("3:Dwarf");
            string choosenRace=Console.ReadLine();
            switch(choosenRace)
            {
                case "1":
                    Console.Clear();
                    ChoosedHuman();
                    break;
                case "2":
                    Console.Clear();
                    ChoosedElf();
                    break;
                case "3":
                    Console.Clear();
                    ChoosedDwarf();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("sorry not valid try again");
                    chooseRace();
                    return;
                    
                    
            };
            
            Console.WriteLine("------------------------------");
            Console.WriteLine("Is "+raceChosen+" your race");
            Console.WriteLine("1:Yes");
            Console.WriteLine("2:No");
            string confirmingRace=Console.ReadLine();
            switch (confirmingRace)
            {
                case "1":
                    Console.Clear();
                    World.DisplayWorld();
                    break;
                case "2":
                    Console.Clear();
                    chooseRace();
                    break; 
                default:
                    Console.WriteLine("Sorry, that's not valid.");
                    Console.Clear();
                    chooseRace();
                    break;
            }

        }

    }
    
}
    

