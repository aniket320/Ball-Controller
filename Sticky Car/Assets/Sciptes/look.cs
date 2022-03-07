using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    public float rotationspeed;
    public Transform shootpoint;
    public Rigidbody balls;
    public float power = 5;
  
    public bool isGrounded;

 

    public void jump()
    {
        balls.useGravity = false;
        StartCoroutine(jumping());
    }


   

    IEnumerator jumping()
    {
        yield return new WaitForSeconds(0.2f);
        balls.useGravity = true;
        balls.velocity = shootpoint.transform.up * power;
    }

   
}
