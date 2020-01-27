using System;
using System.Collections.Generic;
using System.Text;

namespace GreatBallsOfFire.Fireball
{
    class HeroFireballFactory : IFireballFactory
    {
        public Fireball CreateHealing()
        {
            return new Fireball("green", 20, 0, 12, 0);
        }

        public Fireball CreateDamage()
        {
            return new Fireball("red", 12, 8, 0, 0);
        }

        public Fireball CreateShadow()
        {
            return new Fireball("purple", 6, 0, 0, 7);
        }
    }
}
