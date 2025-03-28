using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RangedWarriorSphere : WarriorSphere
{
    int range = 10;
    int damage = 5;
    string weapon = "Bow";
    void Start()
    {
        Attack(range, damage, weapon);
    }

    // Update is called once per frame
  
}
