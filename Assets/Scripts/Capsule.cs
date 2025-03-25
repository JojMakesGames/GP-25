using UnityEngine;

public class Capsule : Evil
{
    public override void TakeDamage()
    {
        int one = 1;
        int two = 2;
       int three = one + two;
        Debug.Log(three);
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
