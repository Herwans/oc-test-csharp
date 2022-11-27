using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcTestCSharp.Core.Model
{
    public class Hero
    {

        public int HealthPoints { get; private set; }
        public int Points { get; private set; }

        public Hero(int healthPoints)
        {
            HealthPoints = healthPoints;
        }

        public void WinFight()
        {
            Points++;
        }

        public void LooseFight(int nb)
        {
            HealthPoints -= nb;
        }
    }
}
