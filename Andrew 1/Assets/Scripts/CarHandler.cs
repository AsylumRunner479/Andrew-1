using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHandler : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject self;
    public HingeJoint[] wheel;
    public WheelCollider[] wheelColliders;
    

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            Vector3 pos;
            Quaternion rotationQ;
            wheelColliders[i].GetWorldPose(out pos, out rotationQ);
            wheelColliders[i].transform.position = pos;
            wheelColliders[i].transform.rotation = rotationQ;
        }
        self.transform.Rotate(0, Input.GetAxis("Horizontal"), 0, 0);
        

    }
}

