using System;

namespace GreatBallsOfFire
{
    class Program
    {
        static bool hero = false;
        static FireballFactory factory = new FireballFactory();

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
                ball = factory.createHeroShadow();
            } else
            {
                ball = factory.createShadow();
            }
            ball.Cast();
        }

        private static void castDamage()
        {
            Fireball ball;
            if (hero)
            {
                ball = factory.createHeroDamage();
            }
            else
            {
                ball = factory.createDamage();
            }
            ball.Cast();
        }

        private static void castHealing()
        {
            Fireball ball;
            if (hero)
            {
                ball = factory.createHeroHealing();
            }
            else
            {
                ball = factory.createHealing();
            }
            ball.Cast();
        }
    }
}
