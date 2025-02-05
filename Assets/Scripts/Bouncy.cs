using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AG2182
{
    public class Bouncy : MonoBehaviour
    {
        public float amp = 2.0f;
        public float freq = 2.0f;
        Vector3 initPos;

        private void Start()
        {
            initPos = transform.position;
        }
        private void Update()
        {
            transform.position = new Vector3(initPos.x, Mathf.Sin(Time.time * freq) * amp + initPos.y, transform.position.z);
        }
    }
}