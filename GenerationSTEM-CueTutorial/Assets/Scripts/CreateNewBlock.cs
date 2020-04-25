using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewBlock : MonoBehaviour
{
    public GameObject prefab;

    void OnMouseDown()
    {
        GameObject obj = Instantiate(prefab, new Vector3(-1.5f, transform.position.y, transform.position.z), Quaternion.identity) as GameObject;
    }
}
