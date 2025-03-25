using UnityEngine;

public class Cubecheck : MonoBehaviour
{
    // changing the int to private/protected would fuck it up
     public int boom;
    public int EncapsulatedThingBig
    {
        get
        {
            return this.boom;
        }
        set
        {
            this.boom = value;
        }
    }
    void Start()
    {
        if (this.boom == 1)
        {
            Destroy(gameObject);
        }
    }
}
