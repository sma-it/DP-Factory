using System;
using System.Collections.Generic;
using System.Text;

namespace GreatBallsOfFire
{
    class FireballFactory
    {
        public Fireball createHealing()
        {
            return new Fireball("slightly green", 2, 0, 3, 0);
        }

        public Fireball createHeroHealing()
        {
            return new Fireball("green", 20, 0, 12, 0);
        }

        public Fireball createDamage()
        {
            return new Fireball("pink", 6, 5.6f, 0, 0);
        }

        public Fireball createHeroDamage()
        {
            return new Fireball("red", 12, 8, 0, 0);
        }

        public Fireball createShadow()
        {
            return new Fireball("deep purple", 3, 0, 0, 3.5f);
        }

        public Fireball createHeroShadow()
        {
            return new Fireball("purple", 6, 0, 0, 7);
        }
    }
}
