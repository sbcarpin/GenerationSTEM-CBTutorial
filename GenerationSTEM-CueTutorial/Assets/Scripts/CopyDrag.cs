﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyDrag : MonoBehaviour
{
    RaycastHit hit;
    public GameObject prefab;

    void OnMouseDown()
    {
        GameObject obj = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
    }
}

//new Vector3(hit.point.x, hit.point.y, hit.point.z)
// try to only create the mouse down once and not the created copies
// do drag option now