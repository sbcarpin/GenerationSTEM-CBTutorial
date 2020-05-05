﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public GameObject bike;
    float defaultMovement;
    //do these temporary values for now (until you can get user input)

    //want to be able to  move back and (positive and negative values)
    public float distance;

    //want to be able to slow down and move faster (WITHIN THE DISTANCE GIVEN!)
    //try timescale? is slows down the time of the movement
    public float speed;

    /* only use this start for testing otherwise dont need it since code
     * will play whe "Play" button is clicked */
    void Start()
    {
        //make sure to have dafault values
        //distance = 10f;
        //speed = 1.0f;
  
        Move();
    }

    //need to add a speed to it
    public void Move()
    {
        //want this to it moved in a constant movemnent
        defaultMovement = Time.deltaTime * 10;

        //if statement 
        //set boundaries
        /* do this by creating a clear object
         * put 4 clear line objects around the bike area
         * have them all have box 2d colliders
         * whenever the bike hits the claer line then have it bounce or something
         * so the user knows not to go over the boundaries
         * can use Range? (doesnt seem like the best approach)
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
