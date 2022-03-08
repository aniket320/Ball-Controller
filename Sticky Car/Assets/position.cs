using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    public Transform player;
    public Transform end;
    // Start is called before the first frame update
    void Start()
    {
        //transform.LookAt(end);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position;
        

    }
}
