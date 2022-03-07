using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bh : MonoBehaviour
{
  
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
        if (collision.gameObject.CompareTag("bot"))
        {
           // var ob = collision.gameObject.transform;
           // ob.parent = transform;
            StartCoroutine(changetag());
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("d"))
        {
            gameObject.tag = "Untagged";
            Destroy(gameObject);
        }
    }

        IEnumerator changetag()
    {
        yield return new WaitForSeconds(2);
        gameObject.tag = "Untagged";
        Destroy(gameObject);
    }

   

}
