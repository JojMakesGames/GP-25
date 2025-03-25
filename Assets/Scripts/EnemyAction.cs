using UnityEngine;
namespace AG2182
{
    public class EnemyAction : MonoBehaviour
    {
        // abstract enemy class that gives the ability to shout swing and set healthpoints
        public abstract class Enemy
        {
            public abstract void Swing();
            public abstract void Shout();

            public abstract void HealthPoints(int healthpoints);
        }
    }
}

