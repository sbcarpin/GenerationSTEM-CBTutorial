using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStopButtonAction : MonoBehaviour
{
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    public GameObject bike;
    float rotationResetSpeed = 1.0f;

    void Start()
    {
        originalPosition = bike.transform.position;
        originalRotation = bike.transform.rotation;
    }

    public void PlayBlockCode()
    {
        //will run the block code for the play button
        Debug.Log("Play Button Clicked");
    }

    public void StopBlockCode()
    {
        /*
         * it may be possible that if it doesnt reset properly to create a
         * new instance of the game object (this could be easier too)
         * For example:
         * GameObject obj = Instantiate(prefab, new Vector3(-1.5f, transform.position.y, transform.position.z), Quaternion.identity) as GameObject;
         */

        //will run the block code for the stop button
        Debug.Log("Stop Button Clicked");

        /* RESET the position of the bike */
        bike.transform.position = originalPosition;
        //bike.transform.rotation = originalRotation;

        //as of 5/04 rotation is not reseting 
        transform.rotation = Quaternion.Slerp(bike.transform.rotation, originalRotation, Time.time * rotationResetSpeed);

        /*if (rigidbody != null)
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }*/
    }
}
