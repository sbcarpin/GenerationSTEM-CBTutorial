using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waiting : MonoBehaviour
{
    /* How will you actually mkae this code work with the bike?
     */

    public float inputTime;
    public GameObject bike;


    /* only use this start for testing otherwise dont need it since code
     * will play whe "Play" button is clicked */
    void Start()
    {
        Wait();
    }

    //willl wait x amount of time before other code runs
    void Wait()
    {
        StartCoroutine(WaitTime());
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(inputTime);
    }
}
