using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperHomework.Classes
{
    public class Player
    {
        public string FirstName { get; set; }
        public int Score { get; set; } = 0;


        public Weapon weapon = new Weapon();
    }
}
