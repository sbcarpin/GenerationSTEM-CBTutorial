using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStopButtonAction : MonoBehaviour
{
    public void PlayBlockCode()
    {
        //will run the block code for the play button
        Debug.Log("Play Button Clicked");
    }

    public void StopBlockCode()
    {
        //will run the block code for the stop button
        Debug.Log("Stop Button Clicked");
    }
}
