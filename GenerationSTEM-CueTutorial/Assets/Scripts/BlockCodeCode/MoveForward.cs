using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public GameObject bike;
    int distance; //will have to get user input for these two values
    int speed;


    // Start is called before the first frame update
    void Start()
    {
        //do these temporary values for now (until you can get user input)
        distance = 10; //vectors?
        speed = 0; //how should i do this? (figure out how to figure out time speed 1 equal 1 second )
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
