using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelrot : MonoBehaviour
{
    public float speed;
    void Update()
    {
       gameObject.transform.Rotate(1*speed, 0 ,0, Space.Self);  
    }
}
