using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void leave()
    {
        gameObject.GetComponent<Collider>().enabled = false;
        StartCoroutine(en());
    }


    IEnumerator en()
    {
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<Collider>().enabled = true;
    }
}
