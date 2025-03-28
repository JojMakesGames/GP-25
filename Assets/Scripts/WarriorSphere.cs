using System;
using UnityEngine;

public class WarriorSphere : MonoBehaviour
{
   protected int HP;
   protected int range = 0;
   protected int damage = 10;
   protected string weapon = "Sword";

    public void Attack(int range, int damage,string weapon)
    {
        Debug.Log($"The Sphere attacks with {weapon} at range {range} dealing {damage} damage");
    }
    void Start()
    {
        Attack(range, damage, weapon);
    }
}
