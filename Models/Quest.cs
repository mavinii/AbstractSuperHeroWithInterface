using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSuperHeroWithInterface.Models
{
    interface IItem
    {
        string name { get; set; }
        int goldValue { get; set; }

        void Equipe();
        void Sell();
    }

    interface IDamageable
    {
        int durability { get; set; }
        void TakeDamage(int _amount);
    }

    class Sword : IItem, IDamageable
    {
        public string name { get; set; }
        public int goldValue { get; set; }
        public int durability { get; set; }

        public Sword(string _name)
        {
            name = _name;
            goldValue = 100;
            durability = 100;
        }

        public void Equipe()
        {
            //throw new NotImplementedException();
            Console.WriteLine($" {name} is equipped");
        }

        public void Sell()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int _damage)
        {
            //throw new NotImplementedException();
            durability -= _damage;
            Console.WriteLine($"{name} is damaged by {_damage}. It now has a durability of {durability}");
        }
    }

}
