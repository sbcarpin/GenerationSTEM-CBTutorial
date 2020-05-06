using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        /* Original copy
         * transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2f, 2f),
            Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);

            THIS DOES NOT WORK EITHER SINCE THIS HAS TO BE WITH A CENTERED OBJECT
         

        transform.position = new Vector3(Mathf.Clamp(4.75f, -3.05f, 3.75f),
            Mathf.Clamp(-0.2f, -3.8f, 3.2f), transform.position.z);*/

    }

    /*
     * For some reason the triggers or colliders are not working
     * im thinking this may be due to that when it moves it just moves the position there
     * it doen't actually go through the border line...
     *
     * void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("collision name = " + col.gameObject.name);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("collision name = " + other.gameObject.name);
    }*/
}
