using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour
{
    private bool isDragging;
    //int click_counter = 0;

    void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (!EventSystem.current.IsPointerOverGameObject() & isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}

//new Vector3(hit.point.x, hit.point.y, hit.point.z)
// try to only create the mouse down once and not the created copies
// do drag option now