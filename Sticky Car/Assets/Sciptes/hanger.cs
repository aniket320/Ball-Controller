using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanger : MonoBehaviour
{
   private float sticktime = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            var ob = collision.gameObject.transform;
            ob.parent = transform;
            StartCoroutine(stickt());
        }
       

    }


  IEnumerator stickt()
    {
        yield return new WaitForSeconds(sticktime);
        Destroy(gameObject);
    }

}
