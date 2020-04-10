using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_OnMouse : MonoBehaviour
{
    public GameObject Action;
    public GameObject Control;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Control.gameObject.SetActive(false);
        Action.gameObject.SetActive(true);
    }
}
