using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Level { get; set; }
        public Race ChosenRace { get; set; }
        public static int X { get; set; } 
        public static int Y { get; set; }
        public Player(string name, Race chosenRace)
        {
            NewGame.playerName = name;
            ChosenRace = chosenRace;

            Health = 100;
            Level = 1;
            Y= 0;
            X = 0;
            Health += ChosenRace.AdditionalHealth;
            Strength += ChosenRace.AdditionalStrength;
            Speed += ChosenRace.AdditionalSpeed;
        }
        

    }
}
