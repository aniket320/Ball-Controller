using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carinstant : MonoBehaviour
{
    public GameObject[] cars;
    public Transform loc;
    public Transform end;
    // Start is called before the first frame update
    void Awake()
    {
        // Instantiate(cars[Random.Range(0, cars.Length)], loc.position, Quaternion.identity);
        GameObject CAR = Instantiate(cars[Random.Range(0,cars.Length)], loc.position,Quaternion.identity);
        CAR.transform.parent = gameObject.transform;
        CAR.transform.LookAt(end);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
