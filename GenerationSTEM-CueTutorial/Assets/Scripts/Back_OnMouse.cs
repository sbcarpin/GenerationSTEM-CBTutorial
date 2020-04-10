using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back_OnMouse : MonoBehaviour
{
    public string sceneName;

    // Update is called once per frame (this code is for an overall click on the scene)
    /*void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(sceneName);
        }
    }*/

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}
