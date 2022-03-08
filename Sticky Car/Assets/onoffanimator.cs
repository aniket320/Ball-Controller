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
        JointDrive jointDriveX = copy.angularXDrive;
        jointDriveX.positionSpring = .5f;
        copy.angularXDrive = jointDriveX;

        JointDrive jointDriveYZ = copy.angularYZDrive;
        jointDriveYZ.positionSpring = .5f;
        copy.angularXDrive = jointDriveYZ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //this.copy.targetRotation = copyrot();
    }

    private Quaternion copyrot()
    {
        return Quaternion.Inverse(this.target.localRotation) * this.targetrot;
    }
}
