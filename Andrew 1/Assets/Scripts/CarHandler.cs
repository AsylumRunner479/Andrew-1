using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHandler : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject self;
    public HingeJoint[] wheel;
    public GameObject[] wheelColliders;
    

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            if (wheelColliders[i].transform.rotation.x <= 20 && wheelColliders[i].transform.rotation.x >= -20)
            {
                wheelColliders[i].transform.Rotate(Input.GetAxis("Horizontal"), 0, 0, Space.Self);
            }
        }
        
        
        

    }
}

