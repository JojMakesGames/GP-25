using UnityEngine;

public abstract class Evil : MonoBehaviour
{

    int health;
    public abstract void TakeDamage();
    public abstract void WeaponType();
    public abstract void Attack();
}
