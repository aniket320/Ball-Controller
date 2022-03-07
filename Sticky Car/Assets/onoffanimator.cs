using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoffanimator : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private ConfigurableJoint copy;


    Quaternion targetrot;
    // Start is called before the first frame update
    void Start()
    {
        this.copy = this.GetComponent<ConfigurableJoint>();
        this.targetrot = this.target.transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        this.copy.targetRotation = copyrot();
    }

    private Quaternion copyrot()
    {
        return Quaternion.Inverse(this.target.localRotation) * this.targetrot;
    }
}
