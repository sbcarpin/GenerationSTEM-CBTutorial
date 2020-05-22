using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move10 : MonoBehaviour
{
    public GameObject bike;
    private float defaultMovement;
    private float distance;
    private float extra_travel;

    // Start is called before the first frame update
    void Start()
    {
        //make sure to have default values
        distance = 10f;
        //this will make the bike travel further * 10 ahead)
        extra_travel = 10f;

        Move(bike);
    }

    //this will make the bike move of a distance of 10
    public void Move(GameObject bike)
    {
        defaultMovement = Time.deltaTime * extra_travel;
        bike.transform.Translate((distance * defaultMovement), 0, 0);
    }
}
