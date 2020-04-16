﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouse : MonoBehaviour
{
    public GameObject Action;
    public GameObject Control;

    private void OnMouseDown()
    {
        Control.gameObject.SetActive(false);
        Action.gameObject.SetActive(false);
    }
}