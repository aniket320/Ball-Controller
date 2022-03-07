using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class touchmove : MonoBehaviour
{
    public float x;
    public float y;
    float smoothness = 0.15f;
    public float rotationspeed;
    Vector3 tr;
    Vector3 currenvelocity;


  ///  Touch Areas for Camera  /////
    public TouchArea touch;

    private void Start()
    {
        x = 40;
    }
    void Update()
    {
        

        y += touch.Touchdis.x * rotationspeed*Time.deltaTime;
        x -= touch.Touchdis.y * rotationspeed*Time.deltaTime;

        x = Mathf.Clamp(x, -40, 90);     /// For Vertical Lock Rotation
        tr = Vector3.SmoothDamp(tr, new Vector3(x, y), ref currenvelocity, smoothness);
        transform.eulerAngles = tr;


    }


    

}
