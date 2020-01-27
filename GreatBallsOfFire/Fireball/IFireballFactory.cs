using System;
using System.Collections.Generic;
using System.Text;

namespace GreatBallsOfFire.Fireball
{
    interface IFireballFactory
    {
        Fireball CreateHealing();
        Fireball CreateDamage();
        Fireball CreateShadow();
    }
}
