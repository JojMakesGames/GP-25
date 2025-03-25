using JetBrains.Annotations;
using System;
using UnityEngine;

public class Cylinder : Evil
{
    public override void TakeDamage()
    {
        Debug.Log("The cylinder takes 2 million dmg");
    }
    public override void WeaponType()
    {
        Debug.Log("the cylinder weilds the dragonslayer");
    }
    public override void Attack()
    {
        Debug.Log("the cylinder swings the dragonslayer");
    }
    

    void Start()
    {
        TakeDamage();
        WeaponType();
        Attack();


    }
    
}
