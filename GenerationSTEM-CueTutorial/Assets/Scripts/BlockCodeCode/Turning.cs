using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turning : MonoBehaviour
{
    /*
     * how will you make it look when it is turned 180 degrees?
     * should we mirror it?
     * maybe an if statement for any 180 to mirror the image?
     */

    public GameObject bike;
    public float rotationDegree;

    /* only use this start for testing otherwise dont need it since code
     * will play whe "Play" button is clicked */
    void Start()
    {

        Turn();
    }


    void Turn()
    {
        bike.transform.Rotate(0, 0, rotationDegree);

    }
}
