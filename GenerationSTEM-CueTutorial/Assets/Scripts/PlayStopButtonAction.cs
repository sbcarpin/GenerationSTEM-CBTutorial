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
        //will run the block code for the stop button
        Debug.Log("Stop Button Clicked");

        /* RESET the position of the bike */
        bike.transform.position = originalPosition;
        //bike.transform.rotation = originalRotation;

        transform.rotation = Quaternion.Slerp(bike.transform.rotation, originalRotation, Time.time * rotationResetSpeed);

        /*if (rigidbody != null)
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }*/
    }
}
