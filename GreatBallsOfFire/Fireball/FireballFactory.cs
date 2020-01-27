using System;
using System.Collections.Generic;
using System.Text;

namespace GreatBallsOfFire.Fireball
{
    class FireballFactory : IFireballFactory
    {
        public Fireball CreateHealing()
        {
            return new Fireball("slightly green", 2, 0, 3, 0);
        }

        public Fireball CreateDamage()
        {
            return new Fireball("pink", 6, 5.6f, 0, 0);
        }

        public Fireball CreateShadow()
        {
            return new Fireball("deep purple", 3, 0, 0, 3.5f);
        }
    }
}
