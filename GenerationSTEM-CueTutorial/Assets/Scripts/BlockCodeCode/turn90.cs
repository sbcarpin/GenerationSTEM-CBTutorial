using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn90 : MonoBehaviour
{
    public GameObject bike;
    private float rotationDegree;

    /* only use this start for testing otherwise dont need it since code
     * will play whe "Play" button is clicked */
    void Start()
    {
        rotationDegree = 90f;
        Turn();
    }

    //this will make the bike turn at a degree of 90
    void Turn()
    {        
        bike.transform.Rotate(0, 0, rotationDegree);
    }

}
