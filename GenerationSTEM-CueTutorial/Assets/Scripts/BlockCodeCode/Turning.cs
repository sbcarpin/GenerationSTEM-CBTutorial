using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turning : MonoBehaviour
{
    /*
     * 
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
        //if the rotation input is grater than 180 than have to flip the y axis
        if(rotationDegree >= 180f)
        {
            bike.transform.Rotate(0, -rotationDegree, 0);
        }
        else
        {
            bike.transform.Rotate(0, 0, rotationDegree);
        }
    }
}
