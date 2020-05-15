using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayStopButtonAction : MonoBehaviour
{
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    public GameObject bike;
    float rotationResetSpeed = 1.0f;
    public Button button;

    void Start()
    {
        originalPosition = bike.transform.position;
        originalRotation = bike.transform.rotation;
        
    }

    public void PlayBlockCode()
    {
        var instance = new MoveForward();
        //will run the block code for the play button
        Debug.Log("Play Button Clicked");

        //play button works with incuding the code in the "on click" on the play button object
        button.GetComponent<Button>().onClick.AddListener(delegate { instance.Move(bike); });

        //what this does is add the code to the bike object but
        //you want to add the bike to the code as a game object
        //you still need it since theres an error in the code??
        //instance = bike.AddComponent<MoveForward>();
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
