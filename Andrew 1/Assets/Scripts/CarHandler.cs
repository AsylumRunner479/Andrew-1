using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHandler : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject self;
    public HingeJoint[] wheel;
    // Update is called once per frame
    void Update()
    {
        self.transform.Rotate(0, Input.GetAxis("Horizontal"), 0, 0);
        if (!(Input.GetAxis("Vertical") <= 0))
        {
            for (int i = 0; i < wheel.Length; i++)
            {
                JointMotor tempJoint = wheel[i].motor;
                tempJoint.targetVelocity = 1000f;
                tempJoint.force += 1f;
                wheel[i].motor = tempJoint;



            }

        }
        else if (!(Input.GetAxis("Vertical") >= 0))
        {
            for (int i = 0; i < wheel.Length; i++)
            {
                JointMotor tempJoint = wheel[i].motor;
                tempJoint.targetVelocity = -1000f;
                tempJoint.force += 1f;
                wheel[i].motor = tempJoint;
            }

        }
        else
        {
            for (int i = 0; i < wheel.Length; i++)
            {
                JointMotor tempJoint = wheel[i].motor;
                tempJoint.force = 0f;
                wheel[i].motor = tempJoint;
            }
        }

    }
}

