using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn180 : MonoBehaviour
{
    public GameObject bike;
    private float rotationDegree;

    /* only use this start for testing otherwise dont need it since code
     * will play whe "Play" button is clicked */
    void Start()
    {
        rotationDegree = 180f;
        Turn();
    }


    void Turn()
    {
        //if the rotation input is 180 than have to flip the y axis
        bike.transform.Rotate(0, -rotationDegree, 0);
    }
}
