using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatConsole.Model
{
    public abstract class Entity : IEntity
    {
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int ManaPoints { get; set; }
        public double BaseDamagePoints { get; set; }

        /// <summary>
        /// Initialise a new Entity
        /// </summary>
        /// <param name="name">Entity Name</param>
        /// <param name="healthpoints">Health Points</param>
        /// <param name="manapoints">Mana Points</param>
        /// <param name="basedamage">Base damage</param>
        Entity(string name, int healthpoints, int manapoints, double basedamage)
        {
            Name = name;
            HealthPoints = healthpoints;
            ManaPoints = manapoints;
            BaseDamagePoints = basedamage;
        }

        virtual public double DoDamage()
        {
            return BaseDamagePoints;
        }

        abstract public void TakeDamage(double damage);
    }
}
