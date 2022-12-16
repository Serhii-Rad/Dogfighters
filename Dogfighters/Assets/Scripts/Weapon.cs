using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public enum AtackType
    {
        OneShoot, DoubleShoot, TripleShoot
    }

    public class Weapon
    {
        public Weapon() 
        {

        }

        public void Shoot(AtackType atackType = AtackType.OneShoot)
        {

        }
    }
}
