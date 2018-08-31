using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatConsole.Model
{
    interface IEntity
    {
        string Name { get; set; }
        int HealthPoints { get; set; }
        int ManaPoints { get; set; }
        double BaseDamagePoints { get; set; }


        double DoDamage();
        void TakeDamage(double damage);
    }
}
