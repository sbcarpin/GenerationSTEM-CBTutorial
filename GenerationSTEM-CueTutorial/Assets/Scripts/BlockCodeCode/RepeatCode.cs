using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatCode : MonoBehaviour
{
    /*
     * need to have figure out how exactly you will have this repeat function work
     * will it go to the gameobject and do that muiltple times (if so howww?)
     * first need to figure out how to do display
     */

    private string objectName;
    

    // Start is called before the first frame update
    void Start()
    {
        Repeat2();
    }

    //use this to identify which block is inside
    //has a second collider but that is a trigger within the repeat block code
    //get the inside block's information to repeat that code
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("collision name = " + col.gameObject.name);
        objectName = col.gameObject.name;

        //remove the "(Clone)" from the name
        objectName = objectName.Substring(0, objectName.IndexOf("("));

        Debug.Log(objectName);
    }

    //can do 6 if statements for each block code and call their code
    // Update is called once per frame
    void Repeat2()
    {
        for (int x = 0; x < 2; x++)
        {

        }
    }
}
