using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_OnMouse : MonoBehaviour
{
    public GameObject Action;
    public GameObject Control;

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Action.gameObject.SetActive(false);
        Control.gameObject.SetActive(true);
    }
}
