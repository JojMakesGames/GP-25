using UnityEngine;

public class FindThings : MonoBehaviour
{// adds the thing field to unity
    [SerializeField]
    Rigidbody thingb;
    void Start()
    {
        //sets rigidbody
        thingb = GetComponent<Rigidbody>();

    }
}
