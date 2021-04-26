using System;
using System.Collections.Generic;
using System.Text;

namespace ktr_msc_ss1
{
    public class Warrior : Character
    {
        public Warrior(string name) : base(name, "Warrior")
        {
            _life = 100;
            _strength = 10;
            _agility = 8;
            _wit = 3;

            Console.WriteLine($"{_name} : My name will go down in history !");
        }

        public override void Attack(string weapon)
        {
            if (string.IsNullOrEmpty(weapon))
            {
                throw new WeaponException($"{_name} : I refuse to fight with my bare hands.");
            }
            if (weapon == "hammer" || weapon == "sword")
            {
                base.Attack(weapon);
                Console.WriteLine($"{_name} : I'll crush you with my {weapon}!");
            }
            else
            {
                throw new WeaponException($"{_name} : A {weapon}?? What should I do with this ?!");
            }
        }

        public override void MoveRight()
        {
            Console.WriteLine($"{_name} : moves right like a bad boy.");
        }

        public override void MoveLeft()
        {
            Console.WriteLine($"{_name} : moves left like a bad boy.");
        }

        public override void MoveForward()
        {
            Console.WriteLine($"{_name} : moves forward like a bad boy.");
        }

        public override void MoveBack()
        {
            Console.WriteLine($"{_name} : moves back like a bad boy.");
        }
    }
}
