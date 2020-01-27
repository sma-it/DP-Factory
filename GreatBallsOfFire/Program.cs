using System;

namespace GreatBallsOfFire
{
    class Program
    {
        static bool hero = false;

        static void Main(string[] args)
        {
            SMUtils.Menu menu = new SMUtils.Menu();
            menu.AddOption('1', "Enter Hero Mode", () => hero = true);
            menu.AddOption('2', "Exit Hero Mode", () => hero = false);
            menu.AddOption('3', "Cast Healing Ball", castHealing);
            menu.AddOption('4', "Cast Damage Ball", castDamage);
            menu.AddOption('5', "Cast Shadow Ball", castShadow);

            menu.Start();
        }

        private static void castShadow()
        {
            Fireball ball;
            if (hero)
            {
                ball = new Fireball("purple", 6, 0, 0, 7);
            } else
            {
                ball = new Fireball("deep purple", 3, 0, 0, 3.5f);
            }
            ball.Cast();
        }

        private static void castDamage()
        {
            Fireball ball;
            if (hero)
            {
                ball = new Fireball("red", 12, 8, 0, 0);
            }
            else
            {
                ball = new Fireball("pink", 6, 5.6f, 0, 0);
            }
            ball.Cast();
        }

        private static void castHealing()
        {
            Fireball ball;
            if (hero)
            {
                ball = new Fireball("green", 20, 0, 12, 0);
            }
            else
            {
                ball = new Fireball("slightly green", 2, 0, 3, 0);
            }
            ball.Cast();
        }
    }
}
