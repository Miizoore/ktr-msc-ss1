using System;
using System.Collections.Generic;
using System.Text;

namespace ktr_msc_ss1
{
    public abstract class Character : Movable
    {
        protected string _name;
        protected int _life = 50;
        protected int _agility = 2;
        protected int _strength = 2;
        protected int _wit = 2;
        private readonly string _rPGClass;

        public string GetName() => _name;
        public int GetLife() => _life;
        public int GetAgility() => _agility;
        public int GetStrength() => _strength;
        public int GetWit() => _wit;
        public string GetRPGClass() => _rPGClass;

        public virtual void Attack(string weapon)
        {       
            Console.WriteLine($"{_name} : Rrrrrrrrr....");
        }

        public virtual void MoveRight()
        {
            Console.WriteLine($"{_name} : moves right");
        }

        public virtual void MoveLeft()
        {
            Console.WriteLine($"{_name} : moves left");
        }

        public virtual void MoveForward()
        {
            Console.WriteLine($"{_name} : moves forward");
        }

        public virtual void MoveBack()
        {
            Console.WriteLine($"{_name} : moves back");
        }

        public Character(string name, string rPGClass)
        {
            _name = name;
            _rPGClass = rPGClass;
        }

        public void Unsheathe()
        {
            Console.WriteLine($"{_name} : unsheathes his weapon.");
        }

        public void TryToAttack(string weapon)
        {
            try
            {
                Attack(weapon);
            }
            catch (WeaponException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }


    }
}
