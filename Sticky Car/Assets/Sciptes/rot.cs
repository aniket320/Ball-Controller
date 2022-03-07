using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot : MonoBehaviour
{
    private Touch touch;
    private Vector2 touchpos;
    private Quaternion RotX;
    private float speed = 0.2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                //RotX=Mathf.Clamp()
                RotX = Quaternion.Euler(0, touch.deltaPosition.x * speed, 0);
                transform.rotation = RotX * transform.rotation;
            }
            
        } 
    }
}
