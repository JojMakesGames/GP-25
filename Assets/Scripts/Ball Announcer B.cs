using UnityEngine;

public class BallAnnouncerB : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public class MyBall
    {
        public string name;
        public string description;
        
    }
    private void Start()
    {
        MyBall ball2 = new MyBall();
        ball2.name = "bouncyball";
        ball2.description = "it bounces!";
        Debug.Log("a new ball" + ball2.name + "is created with description" + ball2.description);
    }
}
