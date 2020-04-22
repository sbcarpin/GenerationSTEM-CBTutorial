using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyDrag : MonoBehaviour
{
    private bool isDragging;
    public GameObject prefab;
    int click_counter = 0;

    void OnMouseDown()
    {
        if (click_counter == 0)
        {
            GameObject obj = Instantiate(prefab, new Vector3(-1.5f, transform.position.y, transform.position.z), Quaternion.identity) as GameObject;
            isDragging = true;
            click_counter = +1;
        }
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}

//new Vector3(hit.point.x, hit.point.y, hit.point.z)
// try to only create the mouse down once and not the created copies
// do drag option now