using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.Collections;

namespace AG2182
{
    public class BallAnnouncerA : MonoBehaviour
    {
        public class MyBall
        {
            public string name;
            public string description;

            public MyBall(string name, string description)
            {
                this.name = name;
                this.description = description;

            }
        }
        private void Start()
        {
            MyBall ball1 = new MyBall("funny ball", "makes you laugh");
            Debug.Log("a new ball" + ball1.name + "is created with description" + ball1.description);
        }
    }



}