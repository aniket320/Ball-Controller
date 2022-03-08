using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stophands : MonoBehaviour
{
    public Rigidbody handss;
    // Start is called before the first frame update
    void Start()
    {
        handss = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ONLeave()
    {
        handss.constraints = RigidbodyConstraints.None;
       // StartCoroutine(delay());
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.5f);
        handss.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;

    }
}
