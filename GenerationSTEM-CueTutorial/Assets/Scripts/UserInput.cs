using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInput : MonoBehaviour
{
    public GameObject input_object;
    InputField input_field;
    public string value;

    public void Start()
    {
        input_field = input_object.GetComponent<InputField>();
        
    }

    public void GetData()
    {
        Debug.Log(input_field.text);
        //currently have an error that it cant get the text value (doesn't work with getcompenet)
        //value = inputField.GetComponent<Text>().text; //for float
        //Debug.Log(value);

        //remember to parse it to get a int/float value instead of a string
    }
}
