using System;
using System.Collections.Generic;
using System.Text;

namespace GreatBallsOfFire
{
    class Fireball
    {
        string color;
        int size;
        float damage;
        float healing;
        float dot;

        public Fireball(string color, int size, float damage, float healing, float dot)
        {
            this.color = color;
            this.size = size;
            this.damage = damage;
            this.healing = healing;
            this.dot = dot;
        }

        public void Cast()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            string result = "Casting ";
            if (size > 10)
            {
                result += "big ";
            } else if (size > 5)
            {
                result += "medium ";
            } else {
                result += "small ";
            }
            result += color + " fireball with ";
            if (damage > 0) result += damage + " damage ";
            if (healing > 0) result += healing + " healing ";
            if (dot > 0) result += dot + " damage over time ";
            return result;
        }
    }
}
