using UnityEngine;

public class BoomValue : MonoBehaviour
{
    public Cubecheck oatmeal;
    private void Start()
    {
        oatmeal = FindAnyObjectByType<Cubecheck>();
        oatmeal.boom = 1;
    }
   
}
