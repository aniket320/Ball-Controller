using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoffanimator : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private ConfigurableJoint copy;


    Quaternion targetrot;

    public bool activerag;
    // Start is called before the first frame update
    void Start()
    {
        this.copy = this.GetComponent<ConfigurableJoint>();
        this.targetrot = this.target.transform.localRotation;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activerag == true)
        {
            JointDrive jointDriveX = copy.angularXDrive;
            jointDriveX.positionSpring = 1f;
            copy.angularXDrive = jointDriveX;

            JointDrive jointDriveYZ = copy.angularYZDrive;
            jointDriveYZ.positionSpring = 1f;
            copy.angularXDrive = jointDriveYZ;
           
        }
       
    }

    private void FixedUpdate()
    {
        if (activerag == false)
        {
            this.copy.targetRotation = copyrot();
        }
    }

    private Quaternion copyrot()
    {
        return Quaternion.Inverse(this.target.localRotation) * this.targetrot;
    }
}
