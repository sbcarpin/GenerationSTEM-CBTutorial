using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public GameObject bike;
    public float defaultMovement;
    //do these temporary values for now (until you can get user input)

    //want to be able to  move back and (positive and negative values)
    public float distance;

    //want to be able to slow down and move faster (WITHIN THE DISTANCE GIVEN!)
    //try timescale? is slows down the time of the movement
    public float speed;

    /* only use this start for testing otherwise dont need it since code
     * will play when "Play" button is clicked */
    void Start()
    {
        //make sure to have default values
        //distance = 10f;
        //speed = 1.0f
  
        Move(bike);
    }

    //need to add a speed to it
    public void Move(GameObject bike)
    {
        //want this to it moved in a constant movemnent
        defaultMovement = Time.deltaTime * 10;

        //if statement 
        //set boundaries
        /*
         * addded the collliders to the border and bikes but now need to make it block
         * any further movement and maybe bounce?
         * 
         */

        //original try but no good
        //bike.transform.position = new Vector3(bike.transform.position.x + (distance * default_movement) * speed, bike.transform.position.y);

        //this below ones works well but  doesnt inlcude speed
        bike.transform.Translate((distance * defaultMovement), 0, 0);

            //this speed adds further movment if added but does it wrong with multipy
            //bike.transform.Translate((distance * default_movement) * (speed * Time.deltaTime), 0, 0);

            //reference the maze game for speed but this did not work (playercontrol.cs)
            //bike.transform.position = (transform.right * distance) * Time.deltaTime * speed;


            //Time.time * speed??????
    }
}
