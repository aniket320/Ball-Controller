using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randompos : MonoBehaviour
{
    public Transform[] posi;
    public Transform loc;

    // Start is called before the first frame update
    void Start()
    {
        loc = posi[Random.Range(0, posi.Length)];
        transform.position = loc.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
