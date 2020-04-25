using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashOption : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("collision name = " + col.gameObject.name);
        Destroy(col.gameObject);

    }

}
