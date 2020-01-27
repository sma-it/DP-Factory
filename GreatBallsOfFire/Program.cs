using GreatBallsOfFire.Fireball;
using System;

namespace GreatBallsOfFire
{
    class Program
    {
        static IFireballFactory ballFactory = new FireballFactory();

        static void Main(string[] args)
        {
            SMUtils.Menu menu = new SMUtils.Menu();
            menu.AddOption('1', "Enter Hero Mode", () => ballFactory = new HeroFireballFactory());
            menu.AddOption('2', "Exit Hero Mode", () => ballFactory = new FireballFactory());
            menu.AddOption('3', "Cast Healing Ball", castHealing);
            menu.AddOption('4', "Cast Damage Ball", castDamage);
            menu.AddOption('5', "Cast Shadow Ball", castShadow);

            menu.Start();
        }

        private static void castShadow()
        {
            ballFactory.CreateShadow().Cast();
        }

        private static void castDamage()
        {
            ballFactory.CreateDamage().Cast();
        }

        private static void castHealing()
        {
            ballFactory.CreateHealing().Cast();
        }
    }
}
