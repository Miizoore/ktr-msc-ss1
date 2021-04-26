using System;
using System.Collections.Generic;
using System.Text;

namespace ktr_msc_ss1
{
    public class Mage : Character
    {
        public Mage(string name) : base(name, "Mage")
        {
            _life = 70;
            _strength = 3;
            _agility = 10;
            _wit = 10;

            Console.WriteLine($"{_name} : May the gods be with me.");
        }

        public override void Attack(string weapon)
        {
            if (string.IsNullOrEmpty(weapon))
            {
                throw new WeaponException($"{_name} : I refuse to fight with my bare hands.");
            }
            if (weapon == "magic" || weapon == "wand")
            {
                base.Attack(weapon);
                Console.WriteLine($"{_name} : Feel the power of my {weapon}!");
            }
            else
            {
                throw new WeaponException($"{_name} : I don't need this stupid {weapon}! Don't misjudge my powers !");
            }
        }

        public override void MoveRight()
        {
            Console.WriteLine($"{_name} : moves right furtively.");
        }

        public override void MoveLeft()
        {
            Console.WriteLine($"{_name} : moves left furtively.");
        }

        public override void MoveForward()
        {
            Console.WriteLine($"{_name} : moves forward furtively.");
        }

        public override void MoveBack()
        {
            Console.WriteLine($"{_name} : moves back furtively.");
        }
    }
}
