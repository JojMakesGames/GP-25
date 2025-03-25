using System;
using UnityEngine;
using static AG2182.EnemyAction;
namespace AG2182
{
    // enemy that inherets from the abstract class uses the HP, Shout and Swing tailored to its specific object.
    public class Sphere : Enemy
    {
        int healthpoints;
        public override void HealthPoints(int healthpoints)
        {
            healthpoints = 5;
            throw new System.NotImplementedException();
        }

        public override void Shout()
        {
            Console.WriteLine("the sphere shouts");
            throw new System.NotImplementedException();
        }

        public override void Swing()
        {
            Console.WriteLine("The sphere attacks");
            throw new System.NotImplementedException();
        }
    }

}
